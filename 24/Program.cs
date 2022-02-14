// Найти кубы чисел от 1 до N

int n;
double result;
Console.WriteLine("Введите число N");
n = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Таблица кубов чисеот от 1 до " + n);

for (int i = 1; i <= n; i++)
{
    System.Console.Write(i + " = ");
    result = Math.Pow(i, 3);
    System.Console.Write(result + "; ");

}


