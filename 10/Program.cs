// Показать последнюю цифру трёхзначного числа
Console.Clear();

Console.WriteLine("Введите любое трехзначное число");
string a= Console.ReadLine();
int b, c;
b= Convert.ToInt32(a);
c= b%10;
System.Console.WriteLine(c);
