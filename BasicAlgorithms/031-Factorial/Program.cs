// Факторил через рекурсию


int F(int N)
{
    if (N == 0) return 1;
    else
    {
        return F(N-1) * N;
    }
}

Loop(10, 1);