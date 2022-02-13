// Дано число обозначающее день недели. Выяснить является номер дня недели выходным

Console.WriteLine("Введите номер дня недели");
int a;
string b;
b= Console.ReadLine();
a=Convert.ToInt32(b);

if (a==6 || a==7) System.Console.WriteLine("Ура, выходной!");
else System.Console.WriteLine("Это не выходной :(");

