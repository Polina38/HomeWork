// Прочитать слово наоборот

Console.Clear();

System.Console.WriteLine("Введите слово");
string s = Console.ReadLine();


for (int i = s.Length - 1; i >= 0; i--)
{
        Console.Write(s[i]);
}