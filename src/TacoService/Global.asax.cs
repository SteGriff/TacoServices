using SwaggerWcf;
using System;
using System.ServiceModel.Activation;
using System.Web.Routing;

namespace Taco.Services.Location
{
    public class Global : System.Web.HttpApplication
    {

        protected void Application_Start(object sender, EventArgs e)
        {
            RouteTable.Routes.Add(new ServiceRoute("docs", new WebServiceHostFactory(), typeof(SwaggerWcfEndpoint)));
        }
    }
}