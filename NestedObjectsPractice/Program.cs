using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Instructor currInst = new Instructor()
            {
                FullName = "Manny Greene",
                Email = "mannygreene@cptc.edu"
            };

            Student stu1 = new Student()
            {
                FirstName = "John",
                LastName = "Doe"
            };

            Student stu2 = new Student()
            {
                FirstName = "Lilly",
                LastName = "Bell"
            };

            Student stu3 = new Student()
            {
                FirstName = "Luis",
                LastName = "Gomez"
            };

            Course testCourse = new Course();
            testCourse.Title = "212 - Adv .NET";
            testCourse.Description = "Even more .NET";
            testCourse.Credits = 5;
            testCourse.CourseInstructor = currInst;
            testCourse.RosterList = new List<Student>();

            // Adding students to the course
            testCourse.RosterList.Add(stu1);
            testCourse.RosterList.Add(stu2);
            testCourse.RosterList.Add(stu3);

            Console.WriteLine(testCourse.Title);
            Console.WriteLine("Is taught by " + testCourse.CourseInstructor.FullName);

            Console.WriteLine("Currently enrolled students: ");
            foreach (Student student in testCourse.RosterList)
            {
                Console.WriteLine($"{student.FirstName} {student.LastName}");
            }
            Console.ReadKey();
        }
    }
}
