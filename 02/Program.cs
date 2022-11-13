// 2. С клавиатуры вводятся два вещественных числа. Проверять является ли одно из них квадратом второго (блок-схема)

System.Console.Write("Ведите a: ");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите b: ");
double b=Convert.ToDouble(Console.ReadLine());
if (a==b*b)
{
    System.Console.WriteLine($"{a} является квадратом {b}");
}
else
{
    if (b==a*a)
    {
        System.Console.WriteLine($"{b} является квадратом {a}");
    }
    else
    {
        System.Console.WriteLine($"Ни {a}, ни {b} не являются квадратом один другого.");
    }
}