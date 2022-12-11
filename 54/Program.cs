// 54.	С клавиатуры вводится число N. Показать первые N чисел Фибоначчи. Принять первые числа равными 0 и 1

// Создаем массив из N первых чисел Фибоначчи
void FibArray(out int[] array, int N)
{
    array = new int[N];
    array[0] = 0;
    array[1] = 1;
    for (int i = 2; i < N; i++)
    {
        array[i] = array[i-1] + array[i-2];
    }
}

// Выводим массив на экран
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    System.Console.Write($"{array[i], 8}");
}

System.Console.Write("Write N: ");
int N = Convert.ToInt32(Console.ReadLine());
int[] array;
FibArray(out array, N);
PrintArray(array);