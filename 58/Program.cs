// Написать программу, которая в двумерном массиве 
// заменяет строки на столбцы или сообщить, что это невозможно (в случае, если матрица не квадратная).


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
    int[,] Table = new int[Array.GetLength(0), Array.GetLength(1)];

    if (Array.GetLength(0) != Array.GetLength(1))
    {
        System.Console.WriteLine("Матрица не квадратная");
       
    }
    else
    {

        for (int i = 0; i < Array.GetLength(0); i++)
        {

            for (int j = 0; j < Array.GetLength(1); j++)
            {
                Table[i, j] = Array[j, i];

                System.Console.Write($"{Table[i, j],3}");


            }

            System.Console.WriteLine();
        }
    }
}

