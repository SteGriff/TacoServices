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
        LocationCollection GetLocations();

        [OperationContract]
        [WebGet(ResponseFormat = WebMessageFormat.Json)]
        LocationCollection SearchLocations(string searchString);
    }
    
}
