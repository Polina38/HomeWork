// Найти сумму чисел одномерного массива стоящих на нечетной позиции

Console.Clear();

int[] arr = new int[10];
Random rang = new Random();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.Next(0, 100);
    System.Console.Write($"{arr[i],5}");
    if (i % 2 != 0) count = count + arr[i];
}
System.Console.WriteLine();
Console.WriteLine("Сумма чисел, стоящих на нечетных позициях массива, равна " + count);
