// 72.	Показать натуральные числа от M до N, N и M заданы

void Numbers(int M, int N)
{
    if (M <= N)
    {
        System.Console.WriteLine(M);
        M++;
        Numbers(M, N);
    }
    
}

Numbers(4, 10);