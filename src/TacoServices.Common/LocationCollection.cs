using System.Collections.Generic;
using System.Runtime.Serialization;

namespace TacoServices.Common
{
    [CollectionDataContract]
    public class LocationCollection : List<Location> 
    {
        public LocationCollection() : base()
        { }

        public LocationCollection(IEnumerable<Location> locations) : base(locations)
        { }
    }
}
