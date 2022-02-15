// Определить, присутствует ли в заданном массиве, некоторое число

Console.Clear();
int[] arr = new int[10];
Random rang = new Random();

for (int i = 0; i < arr.Length; i++)
{
    arr[i] = rang.Next(0, 100);
    System.Console.Write($"{arr[i],3}");
}
System.Console.WriteLine();
Console.WriteLine("Введите заданое число ");
int a;
string b;
b = Console.ReadLine();
a = Int32.Parse(b);
bool flag = false;
bool flag1 = true;

for (int j = 0; j < arr.Length; j++)
{
    if (arr[j] == a)
    {
        System.Console.Write("Заданое число в массиве есть");
        flag1 = false;
        break;
    }
    else
    {
        flag = true;
    }
}

if (flag == true && flag1 == true) System.Console.WriteLine("Заданное число в массиве отсутствует");