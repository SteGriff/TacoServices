using SwaggerWcf.Attributes;
using System.Collections.Generic;
using System.Net;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using Taco.Services.Order.Validation;
using TacoServices.Common;

namespace Taco.Services.Order
{
    [SwaggerWcf("/OrderService.svc/api")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class OrderService : IOrderService
    {
        private List<OrderRequest> _orders;
        private List<OrderRequest> Orders
        {
            get
            {
                if (_orders == null)
                {
                    _orders = new List<OrderRequest>();
                }
                return _orders;
            }
        }

        [SwaggerWcfTag("Orders")]
        [SwaggerWcfResponse(HttpStatusCode.Created, "Order created, value in the response body with id updated")]
        [SwaggerWcfResponse(HttpStatusCode.BadRequest, "Bad request", true)]
        [SwaggerWcfResponse(HttpStatusCode.InternalServerError, "Internal error", true)]
        public Result PlaceOrder(OrderRequest order)
        {
            var result = new OrderValidation().Validate(order);
            if (result.Success)
            {
                Orders.Add(order);
                result.Id = Orders.Count;
            }

            WebOperationContext.Current.OutgoingResponse.StatusCode = result.Success
                ? HttpStatusCode.Created
                : HttpStatusCode.BadRequest;

            return result;
        }


    }
}
