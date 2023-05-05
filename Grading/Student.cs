using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grading
{
    public class Student
    {
        public string Name { get; set; }
        public string ID { get; set; }
        public IList<double>grades { get; set;}

        public Student(string name, string id)
        {
            Name = name;
            ID = id;
            grades = new List<double>();    
        }

        public override string ToString()
        {
           return $"Student name: {Name}\nStudent Id: {ID}\nStudent Grade(s):{grades}";
        }


    }
}
