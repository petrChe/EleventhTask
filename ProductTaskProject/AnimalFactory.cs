using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    abstract class AnimalFactory
    {
        public abstract Movement CreateMovement();
        public abstract Eating CreateEating();
    }
}
