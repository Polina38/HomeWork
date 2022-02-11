// Дано число из отрезка [10, 99]. Показать наибольшую цифру числа

Console.Clear ();
int a,b,c, max;

Random Rang= new Random ();

a= Rang.Next(10,99);
Console.WriteLine("Первое число "+a);

b= Rang.Next(10,99);
Console.WriteLine("Первое число "+b);

c= Rang.Next(10,99);
Console.WriteLine("Первое число "+c);

max=a;
if (b>max) max=b;
if (c>max) max=c;

System.Console.WriteLine("Наибольшее число "+max);