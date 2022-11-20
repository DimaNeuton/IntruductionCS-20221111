// 18.	По двум заданным числам проверять является ли одно квадратом другого

System.Console.Write("Ведите a: ");
double a=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Ведите b: ");
double b=Convert.ToDouble(Console.ReadLine());
if (a==b*b || b==a*a) System.Console.WriteLine("Один является квадратом другого"); else System.Console.WriteLine("No");