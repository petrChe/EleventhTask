using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class LionFactory : AnimalFactory
    {
        public override Eating CreateEating()
        {
            return new RawMeatEating();
        }

        public override Movement CreateMovement()
        {
            return new RunMovement();
        }
    }
}
