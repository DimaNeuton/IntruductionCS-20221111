// 30.	Написать программу вычисления произведения чисел от 1 до N

int Fact(int n, int i)
{
    n = n * (i + 1);
    return n;
}

System.Console.Write("Write N: ");
int N = Convert.ToInt32(Console.ReadLine());
int n = 1;
int i = 1;
while (i < N)
{
    n = Fact(n, i);
    i++;
}
System.Console.WriteLine($"Factorial of {N} = {n}");