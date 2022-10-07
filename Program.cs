using System.Text;
using static System.Net.Mime.MediaTypeNames;

Console.WriteLine("Перевод предложений (слов) из латиницы/кириллицы в вид двоичного кода");
Console.WriteLine("Начало программы!");
Console.WriteLine("Введите слово/предложение");
Console.ReadLine();
String str = "абв";
String ascstr = "";
String binstr = "";
String binstr2 = "";
char[] arr = str.ToCharArray();
foreach (char i in arr)
{
    ascstr += (int)i;
    binstr += Convert.ToString(i, 2);
    String tmp = Convert.ToString(i, 2);
    while (tmp.Length < 16)
        tmp = '0' + tmp;
    binstr2 += tmp;
}
Console.WriteLine(str);
Console.WriteLine(ascstr);
Console.WriteLine(binstr);
Console.WriteLine(binstr2);
int p = 0;
while (p < binstr2.Length)
{
    Char ch = (Char)Convert.ToInt16(binstr2.Substring(p, 16), 2);
    Console.Write(ch);
    p += 16;
}
Console.ReadKey();
