// Показать натуральные числа от N до 1, N задано


Console.Clear();
Input(out int x);
Recurs(x);


void Input(out int n)
{
    System.Console.WriteLine("Введите число N");
    n = Int32.Parse(Console.ReadLine());
    
}

int Recurs(int a)
{
    
    System.Console.Write($"{a} ");
    if (a <= 1) return 1;
    return Recurs(a - 1);
}



