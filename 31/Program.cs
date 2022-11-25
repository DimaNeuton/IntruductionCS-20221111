// 31. Сгенерировать 10 слкчайных чисел и показать кубы чисел, заканчивающихся на четную цифру

/*
int r=10;
double t=r; //неявное приведение типов
double x=23;
//int 0=Convert.ToInt32(x);
int o=(int)x; //явное приведение типов
*/

bool Test(int a)
{
   //if (a%2==0) return true; else return false; 
    return a%2==0;
}

Random rando=new Random(10);
for (int i=0;i<5;i++)
{
    int a=rando.Next(1,100);
    int b=a; //(int)Math.Pow(a,3);
    if (Test(b))

    System.Console.WriteLine($"{a}, {b}");
}
