// Программа проверяет пятизначное число на палиндромом.

Console.Clear();
Console.WriteLine("Введите пятизначное число");
string s = Console.ReadLine();
if (s.Length != 5)
{
    System.Console.WriteLine("Число не из пяти знаков, ошибка");
    return;
}
else
{
    if (s[0] == s[4] && s[1] == s[3]) System.Console.WriteLine("Число является палиндромом");
    else Console.WriteLine("Число не является палиндромом");
    if (s.Length != 5) System.Console.WriteLine("Число не из пяти знаков, ошибка");
}