int len = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

if (str.EndsWith("G"))
{
    str = str.Substring(0, len-1);
}
else
{
    str += "G";
}

Console.WriteLine(str);