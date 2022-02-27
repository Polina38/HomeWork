//Показать двумерный массив размером m×n заполненный вещественными числами

int n,m;
string m1,n1;
Console.WriteLine("Введите количество строк массива");
m1 = Console.ReadLine();
m= Convert.ToInt32(m1);
Console.WriteLine("Введите количество столбцов массива");
n1 = Console.ReadLine();
n= Convert.ToInt32(n1);


double [,] table = new double [m,n];

for (int i=0; i<table.GetLength(0); i++)
{
    for (int j=0; j<table.GetLength(1); j++)
    {
        table [i,j]= new Random().NextDouble()*100;
        System.Console.Write(Math.Round(table[i,j],2)+" ");
    }
    System.Console.WriteLine();
}

