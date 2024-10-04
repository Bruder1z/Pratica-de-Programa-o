using System;
using System.Text;
using System.Net;
using System.Net.Sockets;
using System.IO;

namespace ClienteEnvia
{
    class Program
    {
        static void Main(string[] args)
        {
            FileStream infile;
            int tam, qtd;
            String buffer = "", aux = "";
            String filename = "testeXML.xml";

            infile = new System.IO.FileStream(filename,
                                   System.IO.FileMode.Open,
                                   System.IO.FileAccess.Read);

            tam = (int)infile.Length;
            for (int i = 0; i < tam; ++i)
            {
                 buffer += (char)infile.ReadByte();
            }
            infile.Close();

            Socket socketenviar = new Socket(AddressFamily.InterNetwork, SocketType.Dgram, ProtocolType.IP);
            IPEndPoint endereco = new IPEndPoint(IPAddress.Parse("127.0.0.1"), 9060);
            Console.ReadKey();
            socketenviar.SendTo(Encoding.ASCII.GetBytes(filename), endereco);
            Console.WriteLine("FileName = " + filename);
            qtd = tam / 10;
            if (tam % 10 != 0) ++ qtd;
            socketenviar.SendTo(Encoding.ASCII.GetBytes(qtd.ToString()), endereco);
            Console.WriteLine("QtdDataGramas = " + qtd);
            for (int i = 0, j = 1; i < tam; ++i, ++j)
            {
                aux += buffer[i];
                if (j == 10)
                {
                    int checkSum = 0;//Declara o check Sum
                    foreach (char c in aux)
                    {
                        checkSum += (int)c; //soma os valores
                    }

                    socketenviar.SendTo(Encoding.ASCII.GetBytes(aux), endereco);
                    socketenviar.SendTo(Encoding.ASCII.GetBytes(checkSum.ToString()), endereco);//encia em codigo asciii
                    Console.WriteLine($"PACOTE: {aux}, checksum {checkSum}");//exibe

                    j = 0;
                    aux = "";
                }
            }
            if (tam % 10 != 0)
            {
                Console.WriteLine(aux);
                int checkSum = 0;
                foreach (char c in aux)
                {
                    checkSum += (int)c;
                }
                socketenviar.SendTo(Encoding.ASCII.GetBytes(aux), endereco);
                socketenviar.SendTo(Encoding.ASCII.GetBytes(checkSum.ToString()), endereco);

        }
            socketenviar.Close();
            Console.ReadKey();
         }
   
    }
}
