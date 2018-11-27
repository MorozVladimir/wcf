using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace client_in_code
{
    class Program
    {
        static void Main(string[] args)
        {
            string email = "1";
            while (email!="0")
            {
                ChannelFactory<IEmailValidator> chanelFactory = new ChannelFactory<IEmailValidator>(
                new NetTcpBinding(), new EndpointAddress("net.tcp://localhost:20000"));
                
                IEmailValidator service = chanelFactory.CreateChannel();

                Console.Write("Введите email для проверки на валидность ->");
                email = Console.ReadLine();
                if (string.IsNullOrEmpty(email)) continue;
                bool result = service.ValidateAdress(email);
                if (result == true) Console.WriteLine("этот email валидный");
                else Console.WriteLine("этот email инвалидный");
            }
        }
    }
}
