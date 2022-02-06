// Вывести квадрат числа

Console.Clear();
int c,b;

string a;
Console.WriteLine("Введите любое целое число");
a = Console.ReadLine();
c = Convert.ToInt32(a);
b = (int)Math.Pow(c, 2);

Console.WriteLine("Квадрат Вашего числа равен ");
Console.Write(b);
