// Показать таблицу квадратов чисел от 1 до N
int n, result;
Console.WriteLine("Введите число N");
n = Int32.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
        System.Console.Write(i+" = ");
        result = i * i;
        System.Console.Write(result+"; ");
         
}



