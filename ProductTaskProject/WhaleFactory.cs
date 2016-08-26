using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class WhaleFactory : AnimalFactory
    {
        public override Eating CreateEating()
        {
            return new FishEating();
        }

        public override Movement CreateMovement()
        {
            return new SwimMovement();
        }
    }
}
