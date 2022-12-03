// 35.	Написать программу замены элементов массива на противоположные

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

// Обмен элементов массива
void ElementSwap(out int[] swapArray, int[] array, int size)
{
    swapArray = new int[size];
    for (int i = 1; i <= size; i++)
    {
        swapArray[i-1] = array[size-i];
    }
}

// Вывод нового массива
void PrintSwapArray(int[] swapArray)
{
    for (int i = 0; i < swapArray.Length; i++)
    {
        System.Console.Write($"{swapArray[i], 5}");
    }
}

int[] array;
int[] swapArray;
int size = 10;
int min = 0;
int max = 100;
RandomArray(out array, size, min, max);
PrintArray(array);
System.Console.WriteLine();
ElementSwap(out swapArray, array, size);
PrintSwapArray(swapArray);