using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhTask
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentBinaryTree tree = new StudentBinaryTree();
            tree.InsertIntoTree(new Student("Pit", "transfiguration", new DateTime(2016,01,01,09,0,0),4));
            tree.InsertIntoTree(new Student("Hermione", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 5));
            tree.InsertIntoTree(new Student("Ginny", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 5));
            tree.InsertIntoTree(new Student("Harry", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 4));
            tree.InsertIntoTree(new Student("Ron", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 3));
            tree.InsertIntoTree(new Student("Nevill", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 2));
            tree.InsertIntoTree(new Student("Sheamus", "transfiguration", new DateTime(2016, 01, 01, 09, 0, 0), 3));

            tree.PrintInOrder(tree.Root);
            Console.ReadKey();
        }
    }
}
