// Показать кубы чисел, заканчивающихся на четную цифру


Console.Clear();
int a;
double b;
double result = 1;
Console.WriteLine("Введите любое число, до которого будет осуществляться проверка");
a = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    b = Math.Pow(i, 3);
    if (b % 2 == 0) System.Console.WriteLine(i + " куб этого числа четный " + b);

}
System.Console.WriteLine();

