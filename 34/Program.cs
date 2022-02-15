
// Написать программу замены элементов массива на противоположные

Console.Clear();
int[] arr = new int[5];
Random rang = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.Next(-9, 9);
    System.Console.Write($"{arr[i],2}");
}
System.Console.WriteLine();
for (int j = 0; j < arr.Length; j++)
{
    arr[j] = -arr[j];
    System.Console.Write($"{arr[j],2}");
}

