int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string str = Console.ReadLine();

    if (str[str.Length - 1] != '.')
    {
        str += '.';
    }

    Console.WriteLine(str);
}