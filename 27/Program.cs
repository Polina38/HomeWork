// Определить количество цифр в числе

Console.Clear();
System.Console.WriteLine("Введите любое число");
string s;
int count=0;
s= Console.ReadLine();
for (int i=0; i<s.Length; i++)
{
    count= count+1;
}


Console.WriteLine("В вашем числе цифр "+ count);
