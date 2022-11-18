// 4.	По заданному с клавиатуры номеру дня недели вывести его название

System.Console.Write("Введите номер дня недели: ");
int a=Convert.ToInt32(Console.ReadLine());

if (a==1)
{
    System.Console.WriteLine("Это понедельник");
}
if (a==2)
{
    System.Console.WriteLine("Это вторник");
}
if (a==3)
{
    System.Console.WriteLine("Это среда");
}
if (a==4)
{
    System.Console.WriteLine("Это четверг");
}
if (a==5)
{
    System.Console.WriteLine("Это пятница");
}
if (a==6)
{
    System.Console.WriteLine("Это суббота");
}
if (a==7)
{
    System.Console.WriteLine("Это воскресенье");
}