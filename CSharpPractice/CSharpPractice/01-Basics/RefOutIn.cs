using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice._01_Basics
{
    class RefOutIn
    {
        public static void Run() {
            //ref - out - in
            static void DoubleNumber(ref int num)
            {
                num = num + num;
            }

            int number = 10;

            DoubleNumber(ref number);
            Console.WriteLine(number);

            static void GetUserDetails(out string name, out int age)
            {
                name = "Ashish";
                age = 24;
            }

            string name;
            int age;
            GetUserDetails(out name, out age);
            Console.WriteLine($"Name : {name}");
            Console.WriteLine($"Age : {age}");

            static void DisplayNumber(in int number)
            {
                Console.WriteLine(number);
            }

            int num = 100;
            DisplayNumber(in num);

        }

    }
}
