// Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0


Console.Clear();
Console.WriteLine("Введите значение Х");
int x1, y1;
string b, d;
b = Console.ReadLine();
x1 = Convert.ToInt32(b);

Console.WriteLine("Введите значение Y");
d = Console.ReadLine();
y1 = Convert.ToInt32(d);

if (x1>0 && y1>0) Console.WriteLine("Точка находится в I плоскости");
if (x1>0 && y1<0) Console.WriteLine("Точка находится в IV плоскости");
if (x1<0 && y1>0) Console.WriteLine("Точка находится в II плоскости");
if (x1<0 && y1<0) Console.WriteLine("Точка находится в III плоскости");
if (x1==0 || y1==0) Console.WriteLine("Точка лежит на оси координат и не находится в плоскостях");
