// 40.	Задан массив a из N элементов. Заполнить массив случайными числами от 1 до 10.
// Создайте массив, который является произведением пар чисел в одномерном массиве a.
// Парой считаем первый и последний элемент, второй и предпоследний и т.д.

// Создание массива Array
void RandomA(out int[] a, int N, int min, int max)
{
    a = new int[N];
    Random number = new Random();
    for (int i = 0; i < N; i++)
    {
        a[i] = number.Next(min, max);
    }
}

// Вывод массива Array
void PrintA(int[] a)
{
    for (int i = 0; i < a.Length; i++)
    {
        System.Console.Write($"{a[i], 5}");
    }
}

// Определение количества элементов из отрезка [10,99]
void ProductArray(int[] a, out int[] b)
{
    int i = 1;
    b = new int[a.Length/2];
    while (i <= a.Length/2)
    {
        b[i-1] = a[i-1] * a[a.Length - i];
        i++;
    }
}

void PrintB(int[] b)
{
    for (int i = 0; i < b.Length; i++)
    {
        System.Console.Write($"{b[i], 5}");
    }
}

int[] a;
int[] b;
int N = 10;
int min = 1;
int max = 11;
RandomA(out a, N, min, max);
PrintA(a);
System.Console.WriteLine();
ProductArray(a, out b);
PrintB(b);
