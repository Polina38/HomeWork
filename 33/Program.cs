// Задать массив из 12 элементов, заполненных числами из [-9, 9]. Найти сумму положительных/отрицательных элементов массива

Console.Clear();
int negative = 0;
int positive = 0;
int[] Array = new int[12];
Random rang = new Random();

for (int i = 0; i < Array.Length; i++)
{
    Array[i] = rang.Next(-9, 9);
    System.Console.Write(Array[i] + " ");
    if (Array[i] < 0) negative = negative + Array[i];
    if (Array[i] > 0) positive = positive + Array[i];

}
System.Console.WriteLine();

Console.WriteLine("Сумма отрицательных элементов равна " + negative + "  Сумма положительных элементов равна " + positive);
