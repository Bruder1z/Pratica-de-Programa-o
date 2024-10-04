using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Xml;

namespace Serializacao01
{
    class Program
    {
        static void Main(string[] args)
        {
            List<OcorrenciaPonto> ocorrencias = new List<OcorrenciaPonto>();

            // Lê o arquivo de entrada
            using (StreamReader file = new StreamReader("Abril.txt"))
            {
                string line;
                while ((line = file.ReadLine()) != null)
                {
                    // Divide a linha de acordo com o layout especificado
                    string prontuario = line.Substring(0, 15).Trim();
                    string data = line.Substring(15, 6);
                    string hora = line.Substring(21, 4);
                    string filler = line.Substring(25, 8).Trim(); // Ajuste se necessário

                    // Cria uma nova ocorrência
                    OcorrenciaPonto ocorrencia = new OcorrenciaPonto(prontuario, data, hora, filler);
                    ocorrencias.Add(ocorrencia);

                    // Exibe a ocorrência na tela
                    Console.WriteLine($"Prontuário: {ocorrencia.Prontuario}, Data: {ocorrencia.Data}, Hora: {ocorrencia.Hora}");
                }
            }

            // Serializa a lista de ocorrências para um arquivo XML
            using (FileStream fs = new FileStream("ocorrencias.xml", FileMode.Create))
            {
                DataContractSerializer serializer = new DataContractSerializer(typeof(List<OcorrenciaPonto>));
                serializer.WriteObject(fs, ocorrencias);
            }

            Console.WriteLine("Ocorrências salvas em 'ocorrencias.xml'");
            Console.ReadKey();
        }
    }
}
