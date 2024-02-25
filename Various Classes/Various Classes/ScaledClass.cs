using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_Classes
{
    //A class that cannot be inherited
    sealed internal class ScaledClass
    {
        public void Print()
        {
            Console.WriteLine("Hello World");
        }
    }
}
