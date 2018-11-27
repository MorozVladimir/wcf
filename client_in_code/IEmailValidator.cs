using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace client_in_code
{
    [ServiceContract]
    public interface IEmailValidator
    {
        [OperationContract]
        bool ValidateAdress(string emailAddress);
    }
}
