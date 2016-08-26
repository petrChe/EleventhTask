using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class RawMeatEating : Eating
    {
        public override void Eat()
        {
            Console.WriteLine("Eating the fresh raw meat");
        }
    }
}
