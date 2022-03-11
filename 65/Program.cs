// Спирально заполнить двумерный массив

Console.Clear();
Input(out int x, out int y);
int[,] matrix = new int[x, y];
FillArray(matrix);
PrintArray(matrix);

void Input(out int n, out int m)
{
    System.Console.WriteLine("Введите количество строк массива");
    n = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите количество столбцов массива");
    m = Int32.Parse(Console.ReadLine());
}

void FillArray(int[,] array)

{
    int k = 0; int count = 0; int n = 0; double step; double step1;
    if (array.GetLength(0) != array.GetLength(1))
    {
        step = Math.Min(array.GetLength(0), array.GetLength(1));
    }
    else step = array.GetLength(0);

    step1 = Math.Ceiling(step / 2);
    while (count < step1)
    {

        int i = count;
        for (int j = 0 + count; j < array.GetLength(1) - count; j++)
        {
            if (array[i, j] == 0)

            {
                array[i, j] = k + 1;
                k++;
            }
            else break;
        }

        for (i = count + 1; i < array.GetLength(0) - count; i++)
        {

            int j = array.GetLength(1) - 1 - count;

            if (array[i, j] == 0)

            {
                array[i, j] = k + 1;
                k++;
            }
            else break;

        }

        for (int j = array.GetLength(1) - 2 - count; j >= count; j--)
        {
            i = array.GetLength(0) - 1 - count;
            if (array[i, j] == 0)

            {
                array[i, j] = k + 1;
                k++;
            }
            else break;
        }

        for (n = array.GetLength(0) - 2 - count; n > count; n--)
        {

            int j = count;
            if (array[n, j] == 0)

            {
                array[n, j] = k + 1;
                k++;
            }
            else break;

        }
        count++;
    }

}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            System.Console.Write($"{array[i, j],3}");
        }
        System.Console.WriteLine();
    }
    System.Console.WriteLine();
}


