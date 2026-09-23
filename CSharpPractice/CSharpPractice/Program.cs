using CSharpPractice._01_Basics;

RefOutIn.Run();
ConstReadonly person = new ConstReadonly("Ashish");
person.Display();

int result = StaticExample.Add(10, 15);
Console.WriteLine(result);

StringBuilderExample str = new StringBuilderExample();
str.Run();