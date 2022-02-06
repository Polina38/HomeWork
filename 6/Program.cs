// Написать программу вычисления значения функции y = f(a)

void Pause (string message)
{
    Console.WriteLine(message);
    Console.ReadKey();
}
   Pause("Press any key");

double F(double a)
{
    return a*3;
}
System.Console.WriteLine(F(50));

