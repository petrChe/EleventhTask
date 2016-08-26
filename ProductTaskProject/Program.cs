using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductTaskProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal lion = new Animal(new LionFactory());
            lion.Move();
            lion.Eat();
            Animal whale = new Animal(new WhaleFactory());
            whale.Move();
            whale.Eat();
            Console.ReadKey();
        }
    }
}
