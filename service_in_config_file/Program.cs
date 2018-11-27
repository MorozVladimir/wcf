using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace service_in_config_file
{
    class Program
    {
        static void Main(string[] args)
        {
            ServiceHost host = new ServiceHost(typeof(EmailVolidator));
            host.Open();
            Console.WriteLine("Service run........");
            Console.ReadKey();
            host.Close();
        }
    }
}
