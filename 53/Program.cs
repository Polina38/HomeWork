// В двумерном массиве показать позиции числа, заданного пользователем или указать, что такого элемента нет

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
        Array[i, j] = new Random().Next(1, 100);
        System.Console.Write($"{Array[i, j],3}");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();

System.Console.WriteLine("Введите позицию числа в массиве (строка)");
int n1=Int32.Parse(Console.ReadLine());
System.Console.WriteLine("Введите позицию числа в массиве (столбец)");
int m1=Int32.Parse(Console.ReadLine());
int c=0;

for (int i = 0; i < Array.GetLength(0); i++)
{
    for (int j = 0; j < Array.GetLength(1); j++)
    {
        if (i == n1 && j == m1)
        {
           c=1;
           System.Console.Write($"Число с указанной позицией равно {Array[i, j]}");
           break;
        }
    }
    if (c==1) break;
}
if (c==0) System.Console.WriteLine("Число с указанной позицией отсутствует");


