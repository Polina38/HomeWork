// В Указанном массиве вещественных чисел найдите разницу между максимальным и минимальным элементом

Console.Clear();

double[] arr = new double[10];
Random rang = new Random();
double max, min, diff;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.NextDouble();
    System.Console.Write($"{arr[i],20}");
}
System.Console.WriteLine();

min = arr[0];
max = arr[0];
for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] > max) max = arr[j];
    if (arr[j] < min) min = arr[j];
}

diff = max - min;
System.Console.WriteLine();
Console.WriteLine("Минимальное число в массиве " + min + " Максимальное число в массиве " + max + " Разница " + diff);
