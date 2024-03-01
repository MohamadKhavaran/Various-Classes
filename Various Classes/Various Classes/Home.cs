using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_Classes
{
    internal class Home : InterfaceBuilding
    {
        public void Doors()
        {
            Console.WriteLine("Doors");
        }
        public void Windows()
        {
            Console.WriteLine("Windows");
        }
        public void Garden()
        {
            Console.WriteLine("Garden");
        }

        internal bool IsSwimmingPool()
        {
            return true;
        }


    }
}
