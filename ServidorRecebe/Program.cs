using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.IO;

namespace ServidorRecebe
{
    class Program
    {
        static void Main(string[] args)
        {
            Socket socketreceber = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            EndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            byte[] data = new byte[1024];
            int qtdbytes, qtd;
            String filename;

            socketreceber.Bind(endereco);
            Console.WriteLine("Servidor aguardando dados...");

            // Receber nome do arquivo
            qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);//verifica a quantidade de bytes recebido
            filename = Encoding.ASCII.GetString(data, 0, qtdbytes); 
            Console.WriteLine("Arquivo recebido: " + filename);

            // Receber quantidade de pacotes
            qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
            qtd = int.Parse(Encoding.ASCII.GetString(data, 0, qtdbytes));
            Console.WriteLine("Quantidade de pacotes: " + qtd);

            FileStream outfile = new FileStream(filename, 
                                                FileMode.Create, 
                                                FileAccess.Write);

            for (int i = 0; i < qtd; i++)
            {
                // Receber pacote de dados
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                string pacote = Encoding.ASCII.GetString(data, 0, qtdbytes);
                Console.WriteLine($"Pacote {i + 1} recebido: {pacote}");

                // Receber CheckSum
                qtdbytes = socketreceber.ReceiveFrom(data, ref endereco);
                int checkSumRecebido = int.Parse(Encoding.ASCII.GetString(data, 0, qtdbytes));
                Console.WriteLine($"CheckSum recebido: {checkSumRecebido}");

                // Calcular CheckSum do pacote recebido
                int checkSumCalculado = 0;
                foreach (char c in pacote)
                {
                    checkSumCalculado += (int)c;
                }

                // Verificar se o CheckSum bate
                if (checkSumRecebido != checkSumCalculado)
                {
                    
                    Console.WriteLine("Erro: Pacote corrompido!");
                    break;
                   
                }

                // Se o CheckSum estiver correto, escrever no arquivo
                for (int j = 0; j < pacote.Length; ++j)
                {
                    outfile.WriteByte((byte)pacote[j]);
                }
            }

            outfile.Close();
            socketreceber.Close();
            Console.WriteLine("Recepção concluída.");
            Console.ReadKey();
        }
    }
}
