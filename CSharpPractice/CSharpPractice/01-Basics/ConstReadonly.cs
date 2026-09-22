using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._01_Basics
{
    internal class ConstReadonly
    {
        const double pi = 3.14 ;
        public readonly string Name;
        public ConstReadonly(string name)
        {
            Name = name;
            Name = "Rahul";
        }

        public void Display()
        {
            Console.WriteLine($"Pi: {pi}");
            Console.WriteLine($"Name: {Name}");
        }
    }
}
