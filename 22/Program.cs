// Найти расстояние между точками в пространстве 2D/3D

Console.Clear();
int x1,y1,z1,x2,y2,z2;
double x,y,z, dis;
Console.WriteLine("Введите коррдинату Х первой точки");
x1= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коррдинату Y первой точки");
y1= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коррдинату Z первой точки");
z1= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коррдинату Х второй точки");
x2= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коррдинату Y второй точки");
y2= Int32.Parse(Console.ReadLine());
Console.WriteLine("Введите коррдинату Z второй точки");
z2= Int32.Parse(Console.ReadLine());
x=Math.Pow((x2-x1),2);
y=Math.Pow((y2-y1),2);
z=Math.Pow((z2-z1),2);
dis= Math.Sqrt((x+y+z));
System.Console.Write("Расстояние между точками равно  "+dis);