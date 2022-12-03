// 33.	Задать массив из 8 элементов, заполненных нулями и единицами вывести их на экран

void RandomA(out int[] a, int size, int min, int max)
{
    a = new int[size];
    Random randomNumber = new Random();
    for (int i=0; i < size; i++)
    {
        a[i] = randomNumber.Next(min, max);
    }
}

void PrintA(int[] a)
{
    for(int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i], 5}");
    }
}
int[] a;
RandomA(out a, size:8, min:0, max:2);
PrintA(a);
