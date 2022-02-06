// Даны два числа. Показать большее и меньшее число

Console.Clear();
string a, b;
int c, d;
Console.WriteLine("Введите первое число");
a = Console.ReadLine();
c = Convert.ToInt32(a);
System.Console.WriteLine("Введите второе число");
b = Console.ReadLine();
d = Convert.ToInt32(b);
if (c > d) System.Console.WriteLine("Большее число " + c + " " + "Меньшее число " + d);
else System.Console.WriteLine("Большее число " + d + " " + "Меньшее число " + c);