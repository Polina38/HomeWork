// Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

int[] array = new int[8];
Random rand = new Random();


for (int i = 0; i < 8; i++) 
{
    array[i]=rand.Next(0,2);
    System.Console.WriteLine($"{array[i]}");
}

