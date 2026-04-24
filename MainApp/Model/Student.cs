using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.Model
{
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public int Age { get; set; }
        public string City { get; set; }

        public static List<Student> GetStudents(int? number = 15)
        {
            var students = new List<Student>();

            for(int i = 0; i < number; i++)
            {
                students.Add(new Student { Id=i+1, Name="Name"+i, Age=18+i, City="City"+i });
            }

            return students;
        }
    }
}
