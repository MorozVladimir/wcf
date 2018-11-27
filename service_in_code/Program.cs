using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace service_in_code
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EmailValidator));
            host.AddServiceEndpoint(typeof(IEmailValidator), new NetTcpBinding(), "net.tcp://localhost:20000/Emailvalidator");
            host.Open();
            Console.WriteLine("Service Run.............");
            Console.ReadKey();
            host.Close();
        }
    }
}
