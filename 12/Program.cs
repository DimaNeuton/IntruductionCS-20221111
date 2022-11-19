// 12.	С клавиатуры вводится целое число из  диапазона  [10, 99]. Показать наибольшую цифру числа

/*
System.Console.Write("Введите число от 10 до 99: ");
int a=Convert.ToInt32(Console.ReadLine());


if (a%10>a/10)
{
    System.Console.Write($"{a%10} - наибольшая цифра");
}
else
{
    System.Console.Write($"{a/10} - наибольшая цифра");
}
*/

 int a;
 do
 {
    System.Console.Write("Введите число от 10 до 99: ");
    a=Convert.ToInt32(Console.ReadLine());
     if (a<10 || a>99)
    {
    System.Console.WriteLine("Введено неверное число");
    }
 }
 while (a<10 || a>99);

int max;
 if (a%10>a/10) max=a%10; else max=a/10;
    System.Console.Write($"{max} - наибольшая цифра");
    