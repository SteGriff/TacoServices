using System.Runtime.Serialization;

namespace TacoServices.Common
{
    [DataContract]
    public class Result
    {
        [DataMember]
        public bool Success { get; set; }

        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Message { get; set; }
    }
}
