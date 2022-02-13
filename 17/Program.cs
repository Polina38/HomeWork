// По двум заданным числам проверять является ли одно квадратом другого

Console.Clear();
Console.WriteLine("Введите первое число");
int a, c;
string b, d;
b = Console.ReadLine();
a = Convert.ToInt32(b);

Console.WriteLine("Введите второе число");
d = Console.ReadLine();
c = Convert.ToInt32(d);

if (a == Math.Pow(c, 2)) System.Console.WriteLine("Первое число явлется квадратом второго");
if (c == Math.Pow(a, 2)) System.Console.WriteLine("Второе число явлется квадратом первого");
else Console.WriteLine("Ни одно число не является квадратом другого числа");
