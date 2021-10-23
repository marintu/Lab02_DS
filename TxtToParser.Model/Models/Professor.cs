using System;
using TxtToParser.Model.Enumeration;


namespace TxtToParser.Model.Models
{
    public class Professor : Person
    {
        public Professor(decimal paycheck,string oIB, string name, Gender gender, DateTime dateOfBirth) : base(oIB, name, gender, dateOfBirth)
        {
            Paycheck = paycheck;
        }

        public decimal Paycheck { get; }
    }
}