// Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();

int[] arr = new int[10];
Random rang = new Random();
int count;

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.Next(0, 100);
    System.Console.Write($"{arr[i],5}");
}
System.Console.WriteLine();
for (int j=0; j<arr.Length; j++)
{
    count= arr[j]*arr[arr.Length-1-j];
    System.Console.Write($"{count,5}");
}
