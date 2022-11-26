// 27.	Возведите число А в натуральную степень B используя цикл

int Degree(int A, int C)
{
    C=C*A;
    return C;
}

System.Console.WriteLine("Write A");
int A=Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Write B");
int B=Convert.ToInt32(Console.ReadLine());
int i=1;
int C=1;
while (i<=B)
{
    C=Degree(A, C);
    i=i+1;     
}
System.Console.WriteLine(C);