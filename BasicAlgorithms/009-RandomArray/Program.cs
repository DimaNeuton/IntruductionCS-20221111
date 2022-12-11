//  Массив из случайных чисел

/*
int[] RandomIntArray(int size, int min, int max)
{
    int[] a = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
        a[i] = random.Next(min, max);
    return a;
}
*/

void RandomIntArray(out int[] a, int size)
{
    a = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
        a[i] = random.Next(1, 10);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

int[] m;
RandomIntArray(out m, 20);
Print(m);