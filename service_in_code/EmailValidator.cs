using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.ServiceModel;

namespace service_in_code
{
    public class EmailValidator : IEmailValidator
    {
        public bool ValidateAdress(string emailAddress)
        {
            Console.WriteLine($"Validating: {emailAddress}");
            string pattern = @"^([0-9a-zA-Z]([-.\w]*[0-9a-zA-z])*@(([0-9a-zA-Z])+([-\w]*[0-9a-zA-Z])*\.)+[a-zA-Z]{2,9})$";
            return Regex.IsMatch(emailAddress, pattern);
        }
    }
}
