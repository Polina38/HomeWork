// В двумерном массиве целых чисел 
// Удалить строку и столбец, на пересечении которых расположен наименьший элемент.


Console.Clear();
Input(out int x, out int y);
int[,] Matrix = new int[x, y];
int[,] Matrix1 = new int[x, y];
FillArray(Matrix);
PrintArray(Matrix);
FindMin(Matrix, out int imin, out int jmin);
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
            Array[i, j] = new Random().Next(1, 100);

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

void FindMin(int[,] Array, out int imin, out int jmin)
{

    int min = Array[0, 0]; imin = 0; jmin = 0;

    for (int i = 0; i < Array.GetLength(0); i++)
    {


        for (int j = 0; j < Array.GetLength(1); j++)
        {

            if (Array[i, j] < min)
            {
                min = Array[i, j];
                imin = i; jmin = j;
            }

        }
    }
    System.Console.WriteLine($"минимальное число {min} строка {imin} столбец {jmin}");
}

void Task(int[,] Array)

{
    int[,] Table = new int[Array.GetLength(0), Array.GetLength(1)];

    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {

            Table[i, j] = Array[i, j];
            if (i != imin && j != jmin) System.Console.Write($"{Table[i, j],3}");

        }
        System.Console.WriteLine();
    }
}