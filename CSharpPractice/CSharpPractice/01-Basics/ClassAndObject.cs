using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._01_Basics
{
    internal class ClassAndObject
    {

    }
    class Employee
    {
        string Name;
        int Id;
        int Salary;
        public Employee(string name, int id, int salary)
        {
            Name = name;
            Id = id;
            Salary = salary;
        }
        public string DisplayName()
        {
            StringBuilder emp = new StringBuilder();

            emp.Append("Id = ");
            emp.Append(Id);
            emp.Append(" Name = ");
            emp.Append(Name);
            emp.Append(" Salary = ");
            emp.Append(Salary);

            return emp.ToString();
        }
    }
}
