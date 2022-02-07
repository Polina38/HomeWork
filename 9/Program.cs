// Показать четные числа от 1 до N

Console.Clear();
Console.WriteLine("Введите любое число N");
string a;
int b;
a=Console.ReadLine();
b=Convert.ToInt32(a);
int [] array= new int [b+1];

System.Console.WriteLine("Все четные числа до указанного Вами числа ");
for (int i=1;i<array.Length;i++ )
{
    array[i]=i;
    if (array[i]%2==0) System.Console.Write(array[i]+" ");
}