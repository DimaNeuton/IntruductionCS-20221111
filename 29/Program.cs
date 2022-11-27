// 29.	Подсчитать сумму цифр в числе

int Numb(int a)
{
    int b = a/10;
    return b;
}

System.Console.Write("Write number: ");
int number = Convert.ToInt32(Console.ReadLine());
int i = 0;
while (number>0)
{
    number = Numb(number);
    i++;
}
System.Console.WriteLine($"Number of digits in this number- {i}");