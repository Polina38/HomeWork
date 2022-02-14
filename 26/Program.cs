// Возведите число А в натуральную степень B используя цикл


Console.Clear();
int a, b;
int result = 1;
Console.WriteLine("Введите число A");
a = Int32.Parse(Console.ReadLine());


Console.WriteLine("Введите число В");
b = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= b; i++)
{
    result = result * a;
}
Console.WriteLine("Число " + a + " в степени " + b + " равно " + result);



