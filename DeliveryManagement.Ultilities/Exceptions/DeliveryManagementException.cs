using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeliveryManagement.Ultilities.Exceptions
{
    public class DeliveryManagementException : Exception
    {
        public DeliveryManagementException()
        {
        }

        public DeliveryManagementException(string message)
            : base(message)
        {
        }

        public DeliveryManagementException(string message, Exception inner)
            : base(message, inner)
        {
        }
    }
}
