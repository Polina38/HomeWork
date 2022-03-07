// Показать числа Фибоначчи

Console.Clear();
System.Console.WriteLine("Введите порядковый номер числа, до которого будет показан ряд Фибоначчи");
int s = Int32.Parse(Console.ReadLine());
int[] Array = new int[s];
for (int i = 0; i < Array.Length; i++)
{
    if (i == 0)
    {
        Array[i] = 0;
    }
    if (i == 1)
    {
        Array[i] = 1;
    }
    if (i >= 2)
    {
        Array[i] = Array[i - 1] + Array[i - 2];
    }
    System.Console.Write($"{Array[i],4}");

}
