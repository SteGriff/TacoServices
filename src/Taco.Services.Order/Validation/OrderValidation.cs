using System;
using System.Collections.Generic;
using System.Linq;
using TacoServices.Common;
using TacoServices.Common.Data;

namespace Taco.Services.Order.Validation
{
    public class OrderValidation
    {
        private Dictionary<Func<OrderRequest, bool>, string> _validators;
        private LocationCollection _locations = new LocationsData().GetLocations();

        public OrderValidation()
        {
            _validators = new Dictionary<Func<OrderRequest, bool>, string>
            {
                { o => o.MenuItem != MenuItemEnum.NotSet, "The MenuItem must be set." },
                { o => _locations.Any(l => l.Id == o.LocationId), "The LocationId does not exist." },
                { o => o.Quantity > 0, "The Quantity must be a number more than zero." }
            };
        }

        public Result Validate(OrderRequest order)
        {
            var result = new Result() { Success = true };

            foreach(var rule in _validators)
            {
                if (!rule.Key(order))
                {
                    result.Success = false;
                    result.Message += rule.Value + " ";
                }
            }

            return result;
        }
    }
}