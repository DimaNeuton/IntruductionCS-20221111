// 89. Подсчитать сумму цифр, встречающихся в строке

// string s = "12345";
// int sum = s.ToCharArray().Select(n=>).Sum();
// System.Console.WriteLine(sum);


// Делегаты

// int CountDigits(string s);
// {
//     int count = 0;
//     foreach (char c in s)
//     if (char.IsDigit(c))
//         count++;
//     return count;
// }

// int CountLatin(string s);
// {
//     int count = 0;
//     foreach (char c in s)
//     if (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
//         count++;
//     return count;
// }

// int CountRus(string s);
// {
//     int count = 0;
//     foreach (char c in s)
//     if (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == 'ё' || c == 'Ё')
//         count++;
//     return count;
// }

using System.Linq;

delegate bool IsChar(char c); //сигнатура bool(char)

class Program
{
// static int CountChars(string s, IsChar isChar)
//     {
//         int count = 0;
//         foreach (char c in s)
//         if (isChar(c))
//             count++;
//         return count;
//     }

static int CountChars(string s, Func<char, bool> isChar)
    {
        int count = 0;
        foreach (char c in s)
        if (isChar(c))
            count++;
        return count;
    }


    static bool IsLatin(char c)
    {
        return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
    }

    static bool IsRus(char c)
    {
        return (c >= 'а' && c <= 'я' || c >= 'А' && c <= 'Я' || c == 'ё' || c == 'Ё');
    }

    static void Main()
    {



        // Action
        // Func
        // Делегаты
        string s = "asd123";
        var queary = (from c in s where (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z') select c).Count();
        var sum = (from c in s where char.IsDigit(c) select char.GetNumericValue(c)).Sum();
        System.Console.WriteLine(sum);
/*
        System.Console.WriteLine(CountChars(s, IsLatin));
        System.Console.WriteLine(CountChars(s,
        delegate(char c) // анонимный делегат
        {
            return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }));

        System.Console.WriteLine(CountChars(s,
        (c)=> // лямбда-выражение многострочное
        {
            return (c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z');
        }));   

        System.Console.WriteLine(CountChars(s,
        (c)=> c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z'));
        // лямбда-выражение однострочное
  
        System.Console.WriteLine(CountChars(s, IsRus));
        System.Console.WriteLine(CountChars(s, char.IsDigit));
        // => Лямбда выражения
        */
    }



}






