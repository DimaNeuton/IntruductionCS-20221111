// 70.	Показать натуральные числа от 1 до N, N задано

void Numbers(int i, int N)
{
    if (i <= N)
    {
        System.Console.WriteLine(i);
        i++;
        Numbers(i, N);
    }
    
}

Numbers(1, 10);