// 90. Есть два массива info и data.
// Массив data состоит из нулей и единиц хранящий числа в двоичном представлении. Числа идут друг за другом без разделителей.
// Массив info состоит из чисел, которые представляют количество бит чисел из массива data.
// Составить массив десятичных представлений чисел массива data с учётом информации из массива info.

int[] data={0,1,1,1,1,0,0,0,1};
int[] info={2,3,3,1};
int j = 0;
double[] newArray = new double[info.Length]; // создаем новый массив для десятичных чисел
for (int k = 0; k < info.Length; k++)
{
    double temp= 0; // элемент массива
    for (int i = 0; i < info[k]; i++) // проходим по всем элементам массива data (группами по info[k] штук)
    {
        temp = temp + data[j]*Math.Pow(2, info[k]-1-i); // каждый элемент массива data переводим в десятичную форму и складываем в элемент нового массива
        j++;
    }
    newArray[k] = temp; // наполняем новый массив
    System.Console.Write($"{newArray[k]}, "); //выводим массив на экран
}








