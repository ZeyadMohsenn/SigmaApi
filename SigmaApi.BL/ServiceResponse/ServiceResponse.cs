using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SigmaApi.BL.ServiceResponse
{
    public class ServiceResponse<T>
    {
        public ServiceResponse()
        {

        }

        public ServiceResponse(string message)
        {
            Message = message;
        }

        public ServiceResponse(bool success = false, string message = "")
        {
            Success = success;
            Message = message;
        }
        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
