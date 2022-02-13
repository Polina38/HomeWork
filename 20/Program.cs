// Задать номер четверти, показать диапазоны для возможных координат

Console.Clear();
Console.WriteLine("Введите номер четверти декартовой системы координат");
int a;
string b;
b = Console.ReadLine();
a = Convert.ToInt32(b);

if (a==1) Console.WriteLine("Для этой четверти Х>0 и Y>0");
if (a==2) Console.WriteLine("Для этой четверти Х<0 и Y>0");
if (a==3) Console.WriteLine("Для этой четверти Х<0 и Y<0");
if (a==4) Console.WriteLine("Для этой четверти Х>0 и Y<0");
