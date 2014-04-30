using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            localhostTestWebServices.WebService1 ws = 
                new localhostTestWebServices.WebService1();
            string test = ws.HelloWorld();




            ServiceTest.WebService1SoapClient t
                = new ServiceTest.WebService1SoapClient();
            t.Endpoint.Address = new System.ServiceModel.EndpointAddress(
                "http://localhost:63363/WebService1.asmx");
            string test1 = t.HelloWorld();

        }
    }
}
