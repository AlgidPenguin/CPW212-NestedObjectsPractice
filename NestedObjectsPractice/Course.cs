using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NestedObjectsPractice
{
    class Course
    {
        /// <summary>
        /// The full title of the course.
        /// Example: CPW 212 - Advanced .NET Programming
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// The description of the course from the course catalog.
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The number of college credits awarded for passing the course.
        /// </summary>
        public byte Credits { get; set; }

        /// <summary>
        /// The instructor that teaches the course
        /// </summary>
        public Instructor ClassInstructor { get; set; }

        /// <summary>
        /// The full list of the students currently taking the class.
        /// </summary>
        public List<Student> RosterList { get; set; }
    }
}
