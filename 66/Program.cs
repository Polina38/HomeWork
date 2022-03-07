// Показать натуральные числа от 1 до N, N задано

Console.Clear();
Input(out int x);
Recurs(x);
PrintRecurs(x, Recurs(x));


void Input(out int n)
{
    System.Console.WriteLine("Введите число N");
    n = Int32.Parse(Console.ReadLine());
}

string Recurs(int a)
{

    if (a <= 1) return "1";
    return Recurs(a - 1) + " " + a;

}
void PrintRecurs(int a, string b)
{
    System.Console.Write(" " + b);


}
