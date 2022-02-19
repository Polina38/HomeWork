// Написать программу преобразования десятичного числа в двоичное

Console.Clear();
System.Console.WriteLine("Введите десятичное число");
int s = Int32.Parse(Console.ReadLine());
double b = Math.Ceiling(Math.Log2(s));
int a = Convert.ToInt32(b);

int[] Array = new int[a];

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = s % 2;
    s = s / 2;
    // System.Console.Write($"{Array[i],3}");
}
System.Console.WriteLine();

int[] Arr = new int[a];

for (int n = 0; n < a; n++)
{
    Arr[n]= Array[a-1-n];

    System.Console.Write($"{Arr[n],3}");
}