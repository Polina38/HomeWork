// Выяснить, кратно ли число заданному, если нет, вывести остаток.

Console.Clear();
int a, b, d;
Console.WriteLine("Введите заданное число");
string s = Console.ReadLine();
a = Convert.ToInt32(s);

Console.WriteLine("Введите любое число");
string c = Console.ReadLine();
b = Convert.ToInt32(c);

if (b % a == 0) System.Console.WriteLine("Ваше число кратно заданному");
else System.Console.WriteLine("Остаток от деления составляет " + b % a);
