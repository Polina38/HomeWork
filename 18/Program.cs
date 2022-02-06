// Проверить истинность утверждения ¬(X ⋁ Y) = ¬X ⋀ ¬Y

bool[] arrayX = { false, true };
bool[] arrayY = { false, true };
bool flag = true;
int a1 = 0;
int a2 = 0;

for (int i = 0; i < 2; i++)
{
    for (int j = 0; j < 2; j++)
    {
        if (!(arrayX[i] || arrayY[j]) != !arrayX[i] && !arrayY[j])
        {
            flag = false;
            break;
        }
        a1 = Convert.ToInt32(arrayX[i]);
        a2 = Convert.ToInt32(arrayY[j]);
        System.Console.WriteLine(a1);
        System.Console.WriteLine(a2);
        System.Console.WriteLine(flag);
        System.Console.WriteLine();

    }
}
if (flag = true) Console.WriteLine("Утверждение истинно");
else System.Console.WriteLine("Утверждение ложно");