using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    public class Courses
    {
        public IList<Student> students { get; set; }
        public Courses() 
        {
            students = new List<Student>();
        }
        
        public void AddStudent(Student student)
        {
           students.Add(student);

        }

        public void RemoveStudent(Student student)
        {
            students.Remove(student);

        }

           public void CalculateAverage()
           {
            double totalGrades = 0;
           
            foreach (var item in students)
            {
                for (int i = 0; i < item.grades.Count; i++)
                {
                   totalGrades += item.grades[i]; 
                }  

            }
            Console.WriteLine($"Average score for the student in the course is: {(totalGrades/students.Count):F}");  

           }
    }
}
