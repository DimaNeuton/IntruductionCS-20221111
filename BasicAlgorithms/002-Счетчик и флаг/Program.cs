// See https://aka.ms/new-console-template for more information

System.Console.WriteLine("Введите количество учеников: ");
int N=Convert.ToInt32(Console.ReadLine());
int k=0;
bool flag=false;   // флаг
for (int i=1;i<=N;i++)
{
    System.Console.WriteLine($"Введите количество решенных примеров {i} ученика: ");
    int a=Convert.ToInt32(Console.ReadLine());
    if (a<5) k++; 
    if (a==10) flag=true;
}
if (flag) System.Console.WriteLine("Yes");
else System.Console.WriteLine("No");
System.Console.WriteLine($"Количество неудовлетворительных оценок - {k}");
