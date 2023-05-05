namespace Grading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Abu","Psc/2018/087");
            Student student2 = new Student("Umar", "Psc/2018/007");
            Student student3 = new Student("Ammar", "Psc/2018/017");
            Student student4 = new Student("Uthman", "Psc/2018/006");

            Teacher teacher1 = new Teacher();
            Courses course1= new Courses();

            course1.AddStudent(student1);
            course1.AddStudent(student2);
            course1.AddStudent(student3);
            course1.AddStudent(student4);

            teacher1.AddGrade(student1, 98.0);
            teacher1.AddGrade(student2, 88.0);
            teacher1.AddGrade(student3, 81.6);
            teacher1.AddGrade(student4, 71.9);
            course1.CalculateAverage();
            
            

        }
    }
}