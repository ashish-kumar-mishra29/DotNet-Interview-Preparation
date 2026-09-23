using CSharpPractice._01_Basics;

RefOutIn.Run();
ConstReadonly person = new ConstReadonly("Ashish");
person.Display();

int result = StaticExample.Add(10, 15);
Console.WriteLine(result);

StringBuilderExample str = new StringBuilderExample();
str.Run();

// class and objects
Employee emp1 = new Employee("Ashish",101, 54000);
Console.WriteLine("Employee 01 " + emp1.DisplayName());
Employee emp2 = new Employee("Rahul", 102, 52000);
Console.WriteLine("Employee 02 " + emp2.DisplayName());