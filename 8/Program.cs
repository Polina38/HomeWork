// Показать числа от -N до N


Console.Clear();
Console.WriteLine("Введите любое число N");
string a;
int b;
a=Console.ReadLine();
b=Convert.ToInt32(a);
int [] array= new int [2*b+1];


for (int i=0;i<array.Length;i++ )
{
    array[i]=(-b+i);
    System.Console.Write(array[i]+" ");
}

