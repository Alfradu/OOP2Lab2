using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomCollections
{
    public class OperationRejectedException : System.InvalidOperationException
    {
        public OperationRejectedException()
        {
        }

        public OperationRejectedException(string message) : base(message)
        {
        }
    }
}
