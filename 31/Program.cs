// создать массив из 8 элементов

int [] array= new int [8];
Random range= new Random();

for (int i=0; i<8; i++)
{
    array[i] = Random.Next(0,100);
    Console.WriteLine(array[i]);
}
