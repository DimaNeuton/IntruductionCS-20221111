// 17.	Дано число обозначающее день недели. Выяснить является номер дня недели выходным

System.Console.Write("Введите номер дня недели: ");
int n=Convert.ToInt32(Console.ReadLine());
if (n==6 || n==7) System.Console.WriteLine("Это выходной");
else System.Console.WriteLine("Это будний день");
