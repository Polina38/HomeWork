// В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]


Console.Clear();

int[] arr = new int[123];
Random rang = new Random();
int count = 0;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.Next(-99, 200);
    System.Console.Write($"{arr[i],5}");
    if (arr[i] < 99 && arr[i] >= 10) count = count + 1;
}
System.Console.WriteLine();
System.Console.WriteLine("Количество элементов из отезка [10,99] равно " + count);


