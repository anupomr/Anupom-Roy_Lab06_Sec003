using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anupom_Roy_Lab06_Ex01
{
    public class InputException : Exception
    {
        public InputException() : base("Unexpected Input")
        {

        }
        public InputException(string msg) : base(msg)
        {

        }
    }
}
