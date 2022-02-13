// В двумерном массиве n×k заменить четные элементы на противоположные

Console.Clear();

int n,k;
string n1,k1;
Console.WriteLine("Введите количество строк массива");
n1 = Console.ReadLine();
n= Convert.ToInt32(n1);
Console.WriteLine("Введите количество столбцов массива");
k1 = Console.ReadLine();
k= Convert.ToInt32(k1);

int [,] table = new int [n,k];

for (int i=0; i<table.GetLength(0); i++)
{
    for (int j=0; j<table.GetLength(1); j++)
    {
        table [i,j]= new Random ().Next(1,10);
        System.Console.Write(table[i,j]+" ");
    }
    System.Console.WriteLine();
}
System.Console.WriteLine();
for (int i=0; i<table.GetLength(0); i++)
{
    for (int j=0; j<table.GetLength(1); j++)
    {
        if (table [i,j]%2==0) table[i,j]= -table[i,j];
        System.Console.Write(table[i,j]+" ");
    }
    System.Console.WriteLine();
}



