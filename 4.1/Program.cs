// По заданному номеру дня недели вывести его название

Console.Clear();
System.Console.WriteLine("Введите номер дня недели от 1 до 7");
string d;
int a;

d = Console.ReadLine();
a = (int)Convert.ToInt32(d);

if (a == 1) System.Console.WriteLine("Это понедельник :((");
if (a == 2) System.Console.WriteLine("Это вторник :(");
if (a == 3) System.Console.WriteLine("Это среда :|");
if (a == 4) System.Console.WriteLine("Это четверг :)");
if (a == 5) System.Console.WriteLine("Это пятница :))");
if (a == 6) System.Console.WriteLine("Это суббота! УРА!");
if (a == 7) System.Console.WriteLine("Это воскресенье!");
