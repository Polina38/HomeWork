// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты

Console.Clear();

System.Console.WriteLine("Введите количество строк массива");
int n = Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите количество столбцов массива");
int m = Int32.Parse(Console.ReadLine());
int[,] Array = new int[n, m];

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        Array[i, j] = new Random().Next(1, 10);
        System.Console.Write($"{Array[i, j],3}");
    }
    System.Console.WriteLine();
}

System.Console.WriteLine();
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (i % 2 == 0 && j % 2 == 0)
        {
            Array[i, j] = Array[i, j] * Array[i, j];
            System.Console.Write($"{Array[i, j],3}");
        }
        else System.Console.Write($"{Array[i, j],3}");
    }
    System.Console.WriteLine();

}


