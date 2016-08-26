using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class Animal
    {
        private Movement movement;
        private Eating eating;

        public Animal(AnimalFactory af)
        {
            movement = af.CreateMovement();
            eating = af.CreateEating();
        }

        public void Eat()
        {
            eating.Eat();
        }

        public void Move()
        {
            movement.Move();
        }
    }
}
