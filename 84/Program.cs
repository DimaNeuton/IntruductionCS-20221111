// 84. Определить являются ли введенные с клавиатуры символы правильной записью целого числа. Вычислить сумму цифр введенного числа

string s = Console.ReadLine();
int sum = 0;
foreach (char a in s)
{
    if (char.IsDigit(a) == false)
    {
        System.Console.WriteLine("it is not integer number");
        break;
    }
    sum += int.Parse(a.ToString());
}
System.Console.WriteLine(sum);

