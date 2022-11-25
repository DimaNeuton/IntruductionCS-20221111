// 24.	Вывести на экран таблицу квадратов чисел от 1 до N

int Kvadrat(int i)
{
    int k=(int)Math.Pow(i,2);
    return k;
}
System.Console.WriteLine("Write N");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=N; i++)
    System.Console.WriteLine(Kvadrat(i));
