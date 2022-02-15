// Подсчитать сумму цифр в числе


Console.Clear();
System.Console.WriteLine("Введите любое число");
string s;
int b, c;
int count = 0;
s = Console.ReadLine();
b = Convert.ToInt32(s);

while (b > 0)
{
    c = b % 10;
    count = count + c;
    b = b / 10;
}

Console.WriteLine("Сумма чисел в вашем числе равна " + count);


