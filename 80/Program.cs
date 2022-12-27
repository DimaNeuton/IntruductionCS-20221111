// 80. Вывести на экран кодировку символов по ASCII(с 32 до 122)

char c = '\x0021';

System.Console.WriteLine(c);
System.Console.WriteLine((int)c);
int b = 33;
System.Console.WriteLine((char)b);

for (int i = 32; i <= 122; i++)
{
    System.Console.WriteLine($"{i}     {(char)i}");    
}