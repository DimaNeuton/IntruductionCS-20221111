/*
int a=0,b=0,c=0; //целые
float f=20.4f; //дробные
double d=3.14; //вещественные
string s="asdasd";
char c0='a';
bool flag=true;
int переменная1=0;
*/

//1. С клавиатуры вводится целое число. Вывести квадрат числа (блок-схема)

Console.Clear();

int a;
System.Console.Write("Введи число: ");
string? s=Console.ReadLine();
a=Convert.ToInt32(s);
int b=a*a;
System.Console.WriteLine(a+"^2="+b);
System.Console.WriteLine($"{a}^2={b}"); 