// Написать программу вычисления произведения чисел от 1 до N


Console.Clear();
int a;
double result = 1;
Console.WriteLine("Введите любое число N");
a = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    result = result * i;
}
Console.WriteLine("Произведение чисел от 1 до " + a + " равна " + result);


