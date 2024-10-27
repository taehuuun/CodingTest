string str1 = Console.ReadLine();
string str2 = Console.ReadLine();
string str3 = Console.ReadLine();

if ((str1[0] == 'k' && str2[0] == 'l' && str3[0] == 'p') ||
    (str1[0] == 'k' && str2[0] == 'p' && str3[0] == 'l') ||
    (str1[0] == 'l' && str2[0] == 'k' && str3[0] == 'p') ||
    (str1[0] == 'l' && str2[0] == 'p' && str3[0] == 'k') ||
    (str1[0] == 'p' && str2[0] == 'k' && str3[0] == 'l') ||
    (str1[0] == 'p' && str2[0] == 'l' && str3[0] == 'k'))  
{
    Console.WriteLine("GLOBAL");
}
else
{
    Console.WriteLine("PONIX");
}