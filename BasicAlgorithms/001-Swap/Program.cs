// Обмен значениями двух переменных

/*Классический
int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/

/*Без использования третьей переменной
int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;*/

/*
int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a} b={b}");
*/

System.Console.WriteLine("Введите количество учеников: ");
int N=Convert.ToInt32(Console.ReadLine());
int bad_ans_count=0;
int ans10_count=0;
for (int i=1;i<=N;i++)
{
    System.Console.WriteLine($"Введите количество решенных примеров {i} ученика: ");
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<5) bad_ans_count++;
    if (a==10) ans10_count=1;
}
if (ans10_count==1) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");
System.Console.WriteLine($"Количество неудовлетворительных оценок - {bad_ans_count}");