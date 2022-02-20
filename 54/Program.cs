// В матрице чисел найти сумму элементов главной диагонали

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
int count=0;
for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (i == j)
        {
            count=count+Array[i, j];
            
        }
    }
    
}
Console.WriteLine("Cумма элементов основной вертикали равна "+ count);
