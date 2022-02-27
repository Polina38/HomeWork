// Составить частотный словарь элементов двумерного массива состоящих из чисел от 0 до 99.


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
            Array[i, j] = new Random().Next(0, 100);

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

    int[] Table = new int[100];


    for (int i = 0; i < Array.GetLength(0); i++)
    {

        for (int j = 0; j < Array.GetLength(1); j++)
        {

            Table[Array[i, j]] = Table[Array[i, j]] + 1;

        }
    }

    for (int i = 0; i < Table.Length; i++)
    {
        if (Table[i] != 0) System.Console.WriteLine($"{i} встречается {Table[i]} раз");
    }
}
