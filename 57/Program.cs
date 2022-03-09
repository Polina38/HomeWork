// Написать программу, упорядочивания по убыванию элементы каждой строки двумерной массива.


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


    for (int i = 0; i < Array.GetLength(0); i++)
    {

        int temp = 0;


        for (int j = 0; j < Array.GetLength(1); j++)
        {
            int max = Array[i, j];


            for (int k = j + 1; k < Array.GetLength(1); k++)
            {
                if (Array[i, k] > max)
                {
                    temp = max;
                    max = Array[i, k];
                    Array[i, k] = temp;
                }
                temp = 0;

            }
            Table[i, j] = max;
            System.Console.Write($"{Table[i, j],3}");

        }
        System.Console.WriteLine();
    }
}
