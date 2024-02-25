using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_Classes
{
    // For Abstract Class
    internal class DrivedDogs : AbstractAnimal
    {
        internal override void AnimalSound()
        {
            Console.WriteLine("Bow Bow");
        }
    }
}
