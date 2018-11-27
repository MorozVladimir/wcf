using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace service_in_code
{
    [ServiceContract]
    public interface IEmailValidator
    {
        [OperationContract]
        bool ValidateAdress(string emailAddress);
    }
}
