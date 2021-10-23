using System;
using TxtToParser.Model.Enumeration;


namespace TxtToParser.Model.Models
{
    public class Student : Person
    {
        public Student(string oIB, string name, Gender gender, DateTime dateOfBirth, float avgGrade) : base(oIB, name, gender, dateOfBirth)
        {
            AvgGrade = avgGrade;
        }
        public float AvgGrade{get; set;}
    }
}