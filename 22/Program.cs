// 22.	Программа проверяет пятизначное число на палиндромом

System.Console.Write("Введи пятизначное число: ");
int n=Convert.ToInt32(Console.ReadLine());
if (n/10000==n%10 && (n-n/10000*10000)/1000==(n-n/100*100)/10) System.Console.WriteLine($"{n} - Палиндром");
else System.Console.WriteLine("Попробуй еще");