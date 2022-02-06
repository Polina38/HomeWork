// По двум заданным числам проверять является ли первое квадратом второго

int a = 49, b = 7;
int square = b * b;
// int square2= (int) Math.Pow(b,2);
if (a == square)
{
    Console.WriteLine("a является квадратом b");
}
else Console.WriteLine("a не является квадратом b");
