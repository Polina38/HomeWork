// Выяснить являются ли три числа сторонами треугольника

Console.Clear();

int a,b,c;
string a1,b1,c1;
Console.WriteLine("Введите первое число");
a1= Console.ReadLine();
a=Int32.Parse(a1);
Console.WriteLine("Введите второе число");
b1= Console.ReadLine();
b=Int32.Parse(b1);
Console.WriteLine("Введите третье число");
c1= Console.ReadLine();
c=Int32.Parse(c1);

if (a+b>c && b+c>a && a+c>b) System.Console.WriteLine("Числа являются сторонами треугольника");
else System.Console.WriteLine("Числа не являются сторонами треугольника");
