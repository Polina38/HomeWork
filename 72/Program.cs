// Написать программу возведения числа А в целую степень B


Console.Clear();
Input(out int x, out int y);
Recurs(x, y);
PrintResult(x, y);


void Input(out int n, out int m)
{
    System.Console.WriteLine("Введите число А");
    n = Convert.ToInt32(Console.ReadLine());
    System.Console.WriteLine("Введите число В (степень)");
    m = Convert.ToInt32(Console.ReadLine());

}
System.Console.WriteLine();
int Recurs(int a, int b)
{
    int result;
    if (b <= 0) return 1;

    else
    {
        // (int)Math.Pow (a,
        result = a * Recurs(a, (b - 1));
        return result;
    }
}

void PrintResult(int a, int b)
{
    System.Console.Write($"{"Число "+ a + " в степени " +b +" равно "+Recurs(a, b)}");

}
