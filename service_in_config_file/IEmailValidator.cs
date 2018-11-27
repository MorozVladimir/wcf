using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace service_in_config_file
{
    [ServiceContract]
    public interface IEmailValidator
    {
        [OperationContract]
        bool ValidateAdress(string emailAddress);
    }

    public class EmailVolidator : IEmailValidator
    {
        public bool ValidateAdress(string emailAddress)
        {
            Console.WriteLine($"Validating: {emailAddress}");
            string pattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-z])*@(([0-9a-zA-Z])+([-\w]*[0-9a-zA-Z])*\.)+[a-zA-Z]{2,9})$";
            return Regex.IsMatch(emailAddress, pattern);
        }
    }
}
