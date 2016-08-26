using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class FishEating : Eating
    {
        public override void Eat()
        {
            Console.WriteLine("Eating the fresh fish");
        }
    }
}
