string s = "asdf";
// immutable (неизменяемые строки)
System.Console.WriteLine(s[0]);
for (int i = 0; i < s.Length; i++)
{
    System.Console.WriteLine(s[i]);
}
//s[0] = 'S'; // нельзя изменять строки

char[] cc = s.ToCharArray();
cc[0] = 'S';
s = new String(cc);

System.Text.StringBuilder sb = new System.Text.StringBuilder("asda");
sb[0] = 'S';
s = sb.ToString();

string s1 = "Hello";
string s2 = "Hello";
System.Console.WriteLine(s1 == s2);
System.Console.WriteLine(s1.CompareTo(s2));
System.Console.WriteLine(String.Compare(s1,2,s2,2,4,true));

//s1.Length
s2 = s1.Substring(2,4);
System.Console.WriteLine(s1.IndexOf("as"));
s1 = s1.Replace("ab", "ba");

/*string s = Console.ReadLine();
string[] ss = s.Split(' ');
int[] n = new int[ss.Length];
for (int i = 0; i < ss.Length; i++)
{
    n[i] = Convert.ToInt32(ss[i]);
}
int a = n[0];
int a = n[1];
int a = n[1];
*/

string s = Console.ReadLine().Split(' ');
int[] n = Array.ConvertAll<string,int>(ss,Convert.ToInt32); // обобщенные типы и параметризированные
int a = n[0];
int a = n[1];
int a = n[1];


