using System;
using System.Collections.Generic;

namespace FunStuff.School
{
    public class Student
    {
        public Student()
        {
            Grades = new List<decimal>();
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DOB { get; set; }
        public List<Decimal> Grades { get; set; }        
    }
}

