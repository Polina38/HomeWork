// Выяснить является ли число чётным

Console.Clear();
System.Console.WriteLine("Введите целое число");
String s;
int a;
s=Console.ReadLine();
a=Convert.ToInt32(s);

if (a%2==0) System.Console.WriteLine("Ваше число четное");
else Console.WriteLine("Ваше число нечетное");
