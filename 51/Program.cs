// Задать двумерный массив следующим правилом: Aₘₙ = m+n

Console.Clear();
Input (out int x, out int y);
int [,] Table= new int [x,y];
FillArray (Table);


void Input (out int m, out int n)
{
    System.Console.WriteLine("Введите число строк массива");
    m=Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число столбцов массива");
    n=Int32.Parse(Console.ReadLine());
}

void FillArray (int [,] Array)
{
for (int i=0; i<Array.GetLength(0);i++)
{
    for (int j=0; j<Array.GetLength(1); j++)
    {
        Array [i,j]= i+j;
        System.Console.Write($"{Array[i,j],3}");
    }
    System.Console.WriteLine();
}
}

