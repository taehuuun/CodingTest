int n = int.Parse(Console.ReadLine());
string str = Console.ReadLine();

for (int i = 0; i < str.Length; i++)
{
    if (str[0] != str[i])
    {
        Console.WriteLine("No");
        return;
    }
}

Console.WriteLine("Yes");