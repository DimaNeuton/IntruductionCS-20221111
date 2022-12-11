// 36.	Определить, присутствует ли в заданном массиве, некоторое число

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

// Определение наличия числа в массиве
int DetectNumber(int[] array, int number)
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i] == number) return 1;
        i++;
    }
    return -1;
}

int[] array;
int size = 10;
int min = 0;
int max = 10;
int temp;
RandomArray(out array, size, min, max);
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine($"Write number from {min} to {max-1}: ");

// Ввод числа с клавиатуры
int number = Convert.ToInt32(Console.ReadLine());
temp = DetectNumber(array, number);

// Вывод заключения на экран
if (temp > 0)
System.Console.WriteLine($"This array contains {number}");
else System.Console.WriteLine($"This array doesn't contain {number}");
