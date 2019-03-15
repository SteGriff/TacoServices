using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using TacoServices.Common;
using TacoServices.Common.Data;

namespace Taco.Services.Location
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class LocationService : ILocationService
    {

        public LocationCollection GetLocations()
        {
            return new LocationsData().GetLocations();
        }

        public LocationCollection SearchLocations(string searchString)
        {
            var locations = new LocationsData().GetLocations();
            var filteredLocations = locations.Where(loc => loc.City.Contains(searchString) || loc.Name.Contains(searchString));
            return new LocationCollection(filteredLocations);
        }
    }
}
