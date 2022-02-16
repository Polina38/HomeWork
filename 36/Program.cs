// Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();

int [] arr= new int [10];
Random rang= new Random ();
int countTwo=0;
int count=0;

for (int i=0;i<arr.Length;i++)
{
    arr[i]= rang.Next(100,999);
    System.Console.Write($"{arr[i],5}");
    if (arr[i]%2==0) countTwo= countTwo+1;
    else count=count+1;
}
System.Console.WriteLine();
Console.WriteLine("Количество четных чисел " +countTwo+ " Количество нечетных чисел "+count);
