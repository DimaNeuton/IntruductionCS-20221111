// 25.	Вывести на экран кубы чисел от 1 до N

int Kub(int i)
{
    int k=(int)Math.Pow(i,3);
    return k;
}
System.Console.WriteLine("Write N");
int N=Convert.ToInt32(Console.ReadLine());
for (int i=1; i<=N; i++)
    System.Console.WriteLine(Kub(i));
