﻿// Обмен значениями двух переменных

/*Классический
int a=5;
int b=7;
int temp;
temp=a;
a=b;
b=temp;
*/

/*Без использования третьей переменной
int a=5;
int b=7;
a=a+b;
b=a-b;
a=a-b;*/

int a=5;
int b=7;
a=a^b;
b=a^b;
a=a^b;
System.Console.WriteLine($"a={a} b={b}");