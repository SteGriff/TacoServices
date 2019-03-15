using SwaggerWcf.Attributes;
using System.ServiceModel;
using System.ServiceModel.Web;
using TacoServices.Common;

namespace Taco.Services.Order
{
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        [WebInvoke(Method = "POST", RequestFormat = WebMessageFormat.Json, ResponseFormat = WebMessageFormat.Json)]
        [SwaggerWcfPath("Place Order", "Place a food order")]
        Result PlaceOrder(OrderRequest order);
    }
}
