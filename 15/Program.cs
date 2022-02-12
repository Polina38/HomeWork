// Найти третью цифру числа или сообщить, что её нет

Console.Clear();

System.Console.WriteLine("Введите любое число");

string s = Console.ReadLine();
string s1= String.Empty;
if (s.Length < 3)
{
    System.Console.WriteLine("У Вашего числа нет третьей цифры");
}
else
{
    for (int i = 0; i < s.Length; i++)
    {
        if (i == 2) System.Console.WriteLine("Третье цифра в числе "+s[i]);
    }
}