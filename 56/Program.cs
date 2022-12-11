// 56.	Написать программу копирования массива

// создаем масиив из слцчайных чисел
void RandomArray(out int[] array, int size)
{
    array = new int[size];
    Random number = new Random();
    for (int i = 0; i < size; i++)
    {
        array[i] = number.Next(0,100);
    }
}

// Выводим массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 5}");
}

// Копируем массив в другой массив
void CopyArray(out int[] copyArray, int[] array)
{
    copyArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        copyArray[i] = array[i];
    }
}

// Выводим скопированный массив на экран
void PrintCopyArray(int[] copyArray)
{
    for (int i = 0; i < copyArray.Length; i++)
    System.Console.Write($"{copyArray[i], 5}");
}

int size = 10;
int[] array;
RandomArray(out array, size);
int[] copyArray;
CopyArray(out copyArray, array);
System.Console.WriteLine("Изначальный массив");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Скопированный массив");
PrintCopyArray(copyArray);
System.Console.WriteLine();

// Меняем один элемент в изначальном массиве и снова выводим все на экран
array[5] = 10;
System.Console.WriteLine("Измененный изначальный массив");
PrintArray(array);
System.Console.WriteLine();
System.Console.WriteLine("Скопированный массив остался неизмененным");
PrintCopyArray(copyArray);