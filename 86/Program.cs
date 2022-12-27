// 86. Подсчитать сколько раз определенный символ (например 'a') встречается в строке.

string s = Console.ReadLine();
int i = 0;
foreach (char a in s)
{
    if (a == 'a') i++;
}
System.Console.WriteLine(i);