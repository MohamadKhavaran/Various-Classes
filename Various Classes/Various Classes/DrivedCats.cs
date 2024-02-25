using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Various_Classes
{
    internal class DrivedCats : PolymorphismAnimal
    {
        internal override void AnimalSound()
        {
            Console.WriteLine("Mew Mew");
        }
    }
}
