// 51.	С клавиатуры вводится число N. Затем вводятся N чисел. Определить сколько чисел больше 0 введено с клавиатуры

// Вводим массив с клавиатуры
int[] IntArray(int N)
{
    int[] array = new int[N];
    int i = 0;
    while (i < N)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
        i++;
    }
    return array;
}

// Считаем сколько элементов в массиве больше 0
int Count(int[] array)
{
    int count = 0;
    foreach (int el in array)
    {
        if (el > 0) count++;
    }
    return count;
}

System.Console.Write("Write N: ");
int N = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"Write {N} numbers: ");
int[] array = IntArray(N);

// Выводим результат
System.Console.WriteLine($"{Count(array)} numbers > 0");
