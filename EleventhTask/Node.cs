using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhTask
{
    class Node
    {
        public Student Student { get; set; }
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public Node(Student student)
        {
            this.Student = student;
            LeftNode = null;
            RightNode = null;
        }

        public void Display()
        {
            Console.WriteLine("Student {0} earned {1} for the {2} test. Date - {3}.",
                              Student.Name,
                              Student.Mark,
                              Student.TestName,
                              Student.Date);
        }
    }
}
