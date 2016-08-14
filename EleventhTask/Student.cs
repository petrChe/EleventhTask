using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EleventhTask
{
    class Student
    {
        public string Name { get; set; }
        public string TestName { get; set; }
        public DateTime Date { get; set; }
        public int Mark { get; set; }

        public Student(string name, string testName, DateTime date, int mark)
        {
            this.Name = name;
            this.TestName = testName;
            this.Date = date;
            this.Mark = mark;
        }

        

        public override string ToString()
        {
            return String.Format("Student {0} earned {1} for the {2} test. Date - {3}",
                this.Name,
                this.Mark,
                this.TestName,
                this.Date);
        }
    }
}
