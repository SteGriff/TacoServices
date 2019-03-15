using SwaggerWcf.Attributes;
using System.Runtime.Serialization;

namespace TacoServices.Common
{
    [DataContract]
    [SwaggerWcfDefinition(ExternalDocsUrl = "http://en.wikipedia.org/wiki/Taco", ExternalDocsDescription = "A food order for a customer at a given location")]
    public class OrderRequest
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public int LocationId { get; set; }

        [DataMember]
        public MenuItemEnum MenuItem { get; set; }

        [DataMember]
        public int Quantity { get; set; }

        [DataMember]
        public string CustomerName { get; set; }

    }
}
