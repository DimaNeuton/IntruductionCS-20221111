// 14.	С клавиатуры вводятся два числа a и b. Выяснить, кратно ли число a числу b, если нет, вывести остаток от деления a на b

System.Console.Write("Введите a: ");
int a=Convert.ToInt32(Console.ReadLine());
System.Console.Write("Введите b: ");
int b=Convert.ToInt32(Console.ReadLine());
if (a%b==0)
{
    System.Console.Write($"{a} кратно {b}");
}
else
{
    System.Console.Write($"{a} не кратно {b}. остаток - {a%b}");
}