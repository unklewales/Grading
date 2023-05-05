using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    public class Teacher
    {
        public string Name { get; set; }
        public string Email { get; set; }
        public IList<Courses> course { get; set; }

        public Teacher()
        {
            course = new List<Courses>();
        }

        public void AddGrade(Student student, double grade)
        {
            var studentGrades = student.grades;
            studentGrades.Add(grade);

            foreach (var item in course)
            {
            if (student != item.students)
            {
                    Console.WriteLine("Sorry you are not registered for this course");
            }
              //item.CalculateAverage();
            }
        } 
    }
}
