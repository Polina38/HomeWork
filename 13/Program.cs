// Удалить вторую цифру трёхзначного числа


Console.Clear();

Console.WriteLine("Введите любое трехзначное число");
string a= Console.ReadLine();
int b, c, d;
b= Convert.ToInt32(a);
c= b%10;
d=b/100;
System.Console.WriteLine(d+" "+c);
