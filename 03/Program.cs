// 3.	С клавиатуры вводятся два числа a и b. Найти максимальное из них

System.Console.Write("Введите a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a>b)
{
    System.Console.Write($"{a} - максимальное");
}
else
{
    System.Console.Write($"{b} - максимальное");
}