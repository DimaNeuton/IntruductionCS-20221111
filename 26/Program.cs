// 26.	Найти сумму чисел от 1 до А

int Sum(int k, int i)
{
    k=k+i;
    return k;
}
System.Console.WriteLine("Write A");
int A=Convert.ToInt32(Console.ReadLine());
int i=1;
int k=0;
while (i<=A)
{
    k=Sum(k,i);
    i++;
}
System.Console.WriteLine(k);