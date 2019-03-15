using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace TacoServices.Common
{
    [DataContract]
    public class Location
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }

        [DataMember]
        public string City { get; set; }

        [DataMember]
        public string PostCode { get; set; }

        [DataMember]
        public string StoreType { get; set; }
    }
}
