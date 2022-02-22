// Написать программу, которая обменивает элементы первой строки и последней строки


Console.Clear();
Input(out int x, out int y);
int[,] Matrix = new int[x, y];
FillArray(Matrix);
PrintArray(Matrix);
Task(Matrix);

void Input(out int n, out int m)
{
    System.Console.WriteLine("Введите количество строк массива");
    n = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    m = Int32.Parse(Console.ReadLine());
}

void FillArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            Array[i, j] = new Random().Next(1, 10);

        }
    }

}

void PrintArray(int[,] Array)
{
    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {
            System.Console.Write($"{Array[i, j],3}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}

void Task(int[,] Array)
{
    int temp = 0;

    for (int i = 0; i < Array.GetLength(0); i++)
    {
        for (int j = 0; j < Array.GetLength(1); j++)
        {

            if (i == 0)
            {
                temp = Array[i, j]; Array[i, j] = Array[Array.GetLength(0) - 1, j]; 
                Array[Array.GetLength(0) - 1, j] = temp;
            }

            temp = 0;
            System.Console.Write($"{Array[i, j],3}");

        }
System.Console.WriteLine();
    }
}



