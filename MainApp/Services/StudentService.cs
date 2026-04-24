using MainApp.Model;
using System;
using System.Collections.Generic;
using System.Text;

namespace MainApp.Services
{
    public class StudentService
    {
        private readonly List<Student> _students;

        public StudentService()
        {
            if (_students == null)
            {
                _students = Student.GetStudents();
            }
        }
    }
}
