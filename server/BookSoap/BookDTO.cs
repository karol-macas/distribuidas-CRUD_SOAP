using System.Runtime.Serialization;

[DataContract]
public class BookDTO
{
    [DataMember]
    public string Title { get; set; }

    [DataMember]
    public string Author { get; set; }

    [DataMember]
    public int Year { get; set; }
}