// Найти сумму чисел от 1 до А

Console.Clear();
int a;
int result = 0;
Console.WriteLine("Введите число A");
a = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= a; i++)
{
    result = result + i;
}
Console.WriteLine("Сумма чисел от 1 до " + a + " равна " + result);
