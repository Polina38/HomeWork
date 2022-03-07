// Показать натуральные числа от M до N, N и M заданы

Console.Clear();
Input(out int x, out int y);
Recurs(x, y);
PrintRecurs(x, y, Recurs(x, y));


void Input(out int n, out int m)
{
    System.Console.WriteLine("Введите число M (начало диапазона)");
    n = Int32.Parse(Console.ReadLine());
    System.Console.WriteLine("Введите число N (конец диапазона)");
    m = Int32.Parse(Console.ReadLine());
}
string Recurs(int a, int b)
{

    if (b <= a) return " " + a;
    return Recurs(a, (b - 1)) + " " + b;
}

void PrintRecurs(int a, int b, string c)
{
    System.Console.Write(" " + c);

}

