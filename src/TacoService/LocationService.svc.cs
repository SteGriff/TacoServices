using SwaggerWcf.Attributes;
using System.Linq;
using System.Net;
using System.ServiceModel.Activation;
using TacoServices.Common;
using TacoServices.Common.Data;

namespace Taco.Services.Location
{
    [SwaggerWcf("/LocationService.svc/api")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class LocationService : ILocationService
    {
        [SwaggerWcfTag("Locations")]
        [SwaggerWcfResponse(HttpStatusCode.OK, "List of locations provided")]
        public LocationCollection GetLocations()
        {
            return new LocationsData().GetLocations();
        }

        [SwaggerWcfTag("Locations")]
        [SwaggerWcfResponse(HttpStatusCode.OK, "List of locations provided")]
        public LocationCollection SearchLocations(string searchString)
        {
            searchString = searchString.ToLower();
            var locations = new LocationsData().GetLocations();
            var filteredLocations = locations.Where(loc => loc.City.ToLower().Contains(searchString) || loc.Name.ToLower().Contains(searchString));
            return new LocationCollection(filteredLocations);
        }
    }
}
