using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticeProject1
{
    public class Subject
    {
        public string SubjectName { get; private set; }


        public Subject(string SubName)
        {
          SubjectName = SubName;
        }

        public string GetSubjectName()
        {
            return $"{SubjectName}";
        }
    }
}
