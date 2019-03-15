using SwaggerWcf.Attributes;
using System.ServiceModel;
using System.ServiceModel.Web;
using TacoServices.Common;

namespace Taco.Services.Location
{
    [ServiceContract]
    public interface ILocationService
    {
        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        [SwaggerWcfPath("Get Locations", "Get a list of all locations")]
        LocationCollection GetLocations();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        [SwaggerWcfPath("Search Locations", "Search all locations for those with Name or City which contains the search term")]
        LocationCollection SearchLocations(string searchString);
    }
    
}
