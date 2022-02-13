// Дано число. Проверить кратно ли оно 7 и 23

Console.WriteLine("Введите число");
int c;
string s;
s= Console.ReadLine();
c= Convert.ToInt32(s);

if (c%7!=0) System.Console.WriteLine("Число не кратно 7");
else System.Console.WriteLine("Число кратно 7");

if (c%23!=0) System.Console.WriteLine("Число не кратно 23");
else System.Console.WriteLine("Число кратно 23");