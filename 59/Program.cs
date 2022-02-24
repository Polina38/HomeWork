// В прямоугольной матрице найти строку с наименьшей суммой элементов



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
    int a = 0;
    int sum = 0;
    int minimum = 0;
    int[] Table = new int[Array.GetLength(0)];

    System.Console.WriteLine("Cумма строк массива");

    for (int i = 0; i < Array.GetLength(0); i++)
    {


        for (int j = 0; j < Array.GetLength(1); j++)
        {
            // minimum = sum + Array[0, j];

            sum = sum + Array[i, j];

        }
        Table[i] = sum;
        System.Console.Write($"{Table[i],3}");

        sum = 0;
    }
    minimum = Table[0];
    for (int i = 1; i < Table.Length; i++)
    {
        if (Table[i] < minimum)
        {
            minimum = Table[i];
            a = i;
        }

    }

    System.Console.WriteLine();
    System.Console.WriteLine("Строка с наименьшей суммой " + a);
}
