string str = Console.ReadLine();
string pattern = "qwertyuiopasdfghjklzxcvbnm1234567890_";
str = str.ToLower();
if (Char.IsDigit(str.First()))
{
    Console.WriteLine("NO");
    return;
}
foreach (char c in str)
{
    // Если символ не содержится в pattern, выводим "NO" 
    if (pattern.IndexOf(c) == -1)
    {
        Console.WriteLine("NO");
        return;
    }
}
Console.WriteLine("YES");