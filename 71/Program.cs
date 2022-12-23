// 71.	Показать натуральные числа от N до 1, N задано

void Numbers(int N)
{
    if (N >= 1)
    {
        System.Console.WriteLine(N);
        Numbers(N - 1);
    }
    
}

Numbers(10);
