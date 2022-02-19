// Показать числа Фибоначчи

Console.Clear();
System.Console.WriteLine("Введите порядковый номер числа, до которого будет показан ряд Фибоначчи");
int s = Int32.Parse(Console.ReadLine());
System.Console.Write("0 " + " 1 ");
int[] Array = new int[s];
for (int i = 2; i < Array.Length; i++)
{
    Array[0] = 0;
    Array[1] = 1;
    Array[i] = Array[i - 1] + Array[i - 2];
    System.Console.Write($"{Array[i],4}");
}
