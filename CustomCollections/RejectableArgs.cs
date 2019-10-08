using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CustomDatastructures.Core;

namespace CustomCollections
{
    class RejectableArgs<T> : CustomDatastructures.Core.RejectableEventArgs<T>
    {
        public override bool IsOperationRejected => InternalOperationRejected;
        private bool InternalOperationRejected { get; set; }
        public override void RejectOperation()
        {
            InternalOperationRejected = true;
        }

        public RejectableArgs(Operation operation, T value, int count) : base(operation, value, count)
        {
            InternalOperationRejected = false;
        }
    }
}
