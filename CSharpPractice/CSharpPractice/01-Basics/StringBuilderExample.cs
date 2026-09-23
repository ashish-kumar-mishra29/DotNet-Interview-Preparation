using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._01_Basics
{
    public class StringBuilderExample
    {
        public void Run()
        {
            StringBuilder message = new StringBuilder();
            message.Append("Ashish");
            message.Append("Mishra");

            Console.WriteLine(message.ToString());
        }
    }
}
