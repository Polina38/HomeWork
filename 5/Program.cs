// Найти максимальное из трех чисел

Console.Clear();
System.Console.WriteLine("Введите первое число");
string a1,a2,a3;
int b1,b2,b3,max;

a1 = Console.ReadLine();
b1 = (int)Convert.ToInt32(a1);

System.Console.WriteLine("Введите второе число");

a2 = Console.ReadLine();
b2 = (int)Convert.ToInt32(a2);

System.Console.WriteLine("Введите третье число");

a3 = Console.ReadLine();
b3 = (int)Convert.ToInt32(a3);

max=b1;
if (b2>max) max=b2;
if (b3>max) max=b3;

Console.WriteLine("Максимальное число "+ max);