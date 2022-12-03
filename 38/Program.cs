// 38.	В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

// Создание массива Array
void RandomArray(out int[] array, int size, int min, int max)
{
    array = new int[size];
    Random number = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = number.Next(min, max);
    }
}

// Вывод массива Array
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write($"{array[i], 5}");
    }
}

// Определение количества элементов из отрезка [10,99]
int CountNumbers(int[] array)
{
    int i = 0;
    int count = 0;
    while (i < array.Length)
    {
        if (array[i] > 9 && array[i] < 100) count++;
        i++;
    }
    return count;
}

int[] array;
int size = 123;
int min = 0;
int max = 1000;
RandomArray(out array, size, min, max);
PrintArray(array);
System.Console.WriteLine();

// Вывод заключения на экран
System.Console.WriteLine($"This array contains {CountNumbers(array)} numbers from section [10,99]");