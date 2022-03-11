// Найти сумму элементов от M до N, N и M заданы

Console.Clear();
Input(out int x, out int y, out int sum);
Recurs(x, y, sum);



void Input(out int n, out int m, out int c)
{
    System.Console.WriteLine("Введите число M (начало диапазона)");
    n = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число N (конец диапазона)");
    m = Int32.Parse(Console.ReadLine());
    c = m;
}
System.Console.WriteLine();
string Recurs(int a, int b, int count)
{

    if (b <= a)
    {

        System.Console.WriteLine($"{"Сумма чисел внутри диапазона "+ count}");
        return " ";

    }
    else
    {

        return Recurs(a, (b - 1), count += (b - 1));


    }

}

// void PrintResult(Recurs(int a, int b, int c))
// {
//     System.Console.Write(c);

// }