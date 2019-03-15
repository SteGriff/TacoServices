using Newtonsoft.Json;
using System;
using System.Net;
using TacoServices.Consumer.LocationServiceReference;
using TacoServices.Consumer.OrderServiceReference;

namespace TacoServices.Consumer
{
    class Program
    {
        private static readonly bool SOAP = false;

        static void Main(string[] args)
        {
            Console.WriteLine("TACO CLIENT");
            Console.WriteLine();

            if (SOAP)
            {
                SOAP_TestLocations();
                Console.WriteLine();
                SOAP_TestOrder();
            }
            else
            {
                JSON_TestLocations();
                Console.WriteLine();
                JSON_TestOrder();
            }
            
            Console.WriteLine("End");
            Console.ReadLine();
        }

        private static void SOAP_TestLocations()
        {
            Console.WriteLine("== All Locations ==");
            var client = new LocationServiceClient();
            var locations = client.GetLocations();
            PrintLocations(locations);

            var searchString = "ham";
            Console.WriteLine();
            Console.WriteLine("== Locations matching '{0}' ==", searchString);
            locations = client.SearchLocations(searchString);
            PrintLocations(locations);
        }

        private static void JSON_TestLocations()
        {
            Console.WriteLine("== All Locations ==");
            LocationCollection locations = null;
            using (var client = new WebClient())
            {
                var json = client.DownloadString("http://localhost:61142/LocationService.svc/api/GetLocations");
                try
                {
                    locations = JsonConvert.DeserializeObject<LocationCollection>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid data from server:");
                    Console.WriteLine(ex.ToString());
                }
            }

            PrintLocations(locations);

            var searchString = "ham";
            Console.WriteLine();
            Console.WriteLine("== Locations matching '{0}' ==", searchString);
            using (var client = new WebClient())
            {
                var json = client.DownloadString("http://localhost:61142/LocationService.svc/api/SearchLocations?searchString="+searchString);
                try
                {
                    locations = JsonConvert.DeserializeObject<LocationCollection>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid data from server:");
                    Console.WriteLine(ex.ToString());
                }
            }
            PrintLocations(locations);
        }

        private static void SOAP_TestOrder()
        {
            Console.WriteLine("== Place an Order ==");

            var order = new OrderRequest()
            {
                CustomerName = "Ste Griffiths",
                LocationId = 70,
                MenuItem = MenuItemEnum.Taco,
                Quantity = 4
            };

            var client = new OrderServiceClient();
            var result = client.PlaceOrder(order);

            Console.WriteLine("Success?: {0}, Id: {1}, Message: {2}", result.Success, result.Id, result.Message);
        }

        private static void JSON_TestOrder()
        {
            Console.WriteLine("== Place an Order ==");

            var order = new OrderRequest()
            {
                CustomerName = "Ste Griffiths",
                LocationId = 70,
                MenuItem = MenuItemEnum.Taco,
                Quantity = 4
            };

            string requestJson = JsonConvert.SerializeObject(order);
            Console.WriteLine(requestJson);
            Result result = null;

            using (var client = new WebClient())
            {
                client.Headers.Add(HttpRequestHeader.ContentType, "application/json");
                string json = "";
                try
                {
                    json = client.UploadString("http://localhost:18070/OrderService.svc/api/PlaceOrder", requestJson);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Request failed:");
                    Console.WriteLine(ex.ToString());
                    return;
                }
                
                try
                {
                    result = JsonConvert.DeserializeObject<Result>(json);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Invalid data from server:");
                    Console.WriteLine(ex.ToString());
                }
            }
            
            Console.WriteLine("Success?: {0}, Id: {1}, Message: {2}", result.Success, result.Id, result.Message);
        }

        private static void PrintLocations(LocationCollection locations)
        {
            if (locations == null)
            {
                Console.WriteLine("Locations is null!");
                return;
            }

            foreach (var loc in locations)
            {
                Console.WriteLine("{0}: {1} ({2})", loc.Id, loc.Name, loc.PostCode);
            }
        }
    }
}
