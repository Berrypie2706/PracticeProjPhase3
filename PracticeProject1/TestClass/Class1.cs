using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using PracticeProject1;

namespace TestClass
{
    [TestFixture]
    public class Class1
    {
        [Test]
        public void TestTeacher()
        {
            var teacher = new Teacher("Simran", "Jha");
            string fullName = teacher.GetFullName();
            Assert.AreEqual("Simran Jha", fullName);
        }

        [Test]
        public void TestStudent()
        {
            var student = new Student("Alok", "Pandey");
            string fullName = student.GetFullName();
            Assert.AreEqual("Alok Pandey", fullName);
        }

        [Test]
        public void TestSubject()
        {
            var subject = new Subject("Maths");
            string subName = subject.GetSubjectName();
            Assert.AreEqual("Maths", subName);
        }


    }
}
