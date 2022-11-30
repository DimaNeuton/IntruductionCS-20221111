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

void RandomIntArray(int[] a, int size, int min, int max)
{
    a = new int[size];
    Random random = new Random();
    for (int i=0; i < size; i++)
        a[i] = random.Next(min, max);
}

void Print(int[] a)
{
    for (int i = 0; i < a.Length; i++)
        System.Console.Write($"{a[i],5}");
}

int[] m = new int[10];
RandomIntArray(m);
Print(m);