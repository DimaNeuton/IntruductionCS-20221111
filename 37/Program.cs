// 37.	Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

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
int OddNumbers(int[] array, int temp)
{
    int i = 0;
    while (i < array.Length)
    {
        if (array[i]%2 == 1) temp++;
        i++;
    }
    return temp;
}

int[] array;
int size = 10;
int min = 100;
int max = 1000;
int temp = 0;
RandomArray(out array, size, min, max);
PrintArray(array);
System.Console.WriteLine();

// Ввод числа с клавиатуры
int count = OddNumbers(array, temp);

// Вывод заключения на экран
System.Console.WriteLine($"This array contains {count} odd numbers");
System.Console.WriteLine($"This array contains {size - count} even numbers");

