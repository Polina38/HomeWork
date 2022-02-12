// Показать двумерный массив размером m×n заполненный целыми числами

int n,m;
string m1,n1;
Console.WriteLine("Введите количество строк массива");
m1 = Console.ReadLine();
m= (int) Convert.ToInt32(m1);
Console.WriteLine("Введите количество столбцов массива");
n1 = Console.ReadLine();
n= (int) Convert.ToInt32(n1);

int [,] table = new int [m,n];
// void FillArray (int [,] table)
// {
for (int i=0; i<table.GetLength(0); i++)
{
    for (int j=0; j<table.GetLength(1); j++)
    {
        table [i,j]= new Random ().Next(1,10);
        System.Console.Write(table[i,j]+" ");
    }
    System.Console.WriteLine();
}

// FillArray(table);