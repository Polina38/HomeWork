// Показать вторую цифру трёхзначного числа

Console.Clear();

Console.WriteLine("Введите любое трехзначное число");
string a= Console.ReadLine();
int b, c, d;
b= Convert.ToInt32(a);
c= b%100;
d=c/10;
System.Console.WriteLine(d);
