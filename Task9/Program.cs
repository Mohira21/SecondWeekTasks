string[] str1 = { "H", "e", "l", "l", "o" };
string[] str2 = { "World" };

string[] str3 = new string[str1.Length + str1.Length];

Array.Copy(str1, str3, str1.Length);
Array.Copy(str2, 0, str3, str1.Length, str2.Length);
foreach (var e in str3)
{
    Console.Write(e + " ");
}