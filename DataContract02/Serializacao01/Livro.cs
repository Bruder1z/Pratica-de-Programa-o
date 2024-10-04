using System.Runtime.Serialization;

[DataContract]
public class OcorrenciaPonto
{
    [DataMember]
    public string Prontuario { get; set; }

    [DataMember]
    public string Data { get; set; }

    [DataMember]
    public string Hora { get; set; }

    [DataMember]
    public string Filler { get; set; }

    public OcorrenciaPonto(string prontuario, string data, string hora, string filler)
    {
        Prontuario = prontuario;
        Data = data;
        Hora = hora;
        Filler = filler;
    }
}
