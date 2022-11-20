// 20.	Определить номер четверти плоскости, в которой находится точка с координатами Х и У, причем X ≠ 0 и Y ≠ 0

System.Console.Write("Введите координату x: ");
double x=Convert.ToDouble(Console.ReadLine());
System.Console.Write("Введите координату y: ");
double y=Convert.ToDouble(Console.ReadLine());

if (x>0 && y>0) System.Console.WriteLine("Это первая четверть");
if (x<0 && y>0) System.Console.WriteLine("Это вторая четверть");
if (x<0 && y<0) System.Console.WriteLine("Это третья четверть");
if (x>0 && y<0) System.Console.WriteLine("Это четвертая четверть");