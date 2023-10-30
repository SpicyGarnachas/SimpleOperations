using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpicyGarnachas.SimpleOperations.Exceptions
{
    class SetPersonalizedException : Exception
    {
        public SetPersonalizedException(string message) : base(message)
        {

        }
    }
}
