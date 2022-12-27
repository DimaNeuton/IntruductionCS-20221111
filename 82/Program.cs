// 82. C клавиатуры вводится строка разделенная точкой. Подсчитать количество символов до точки

string s = Console.ReadLine();
char[] a = s.ToCharArray();
int i = 0;
while (a[i] != '.')
{
    i++;
}
System.Console.WriteLine($"Количетво символов до точки - {i}");
