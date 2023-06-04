int n = int.Parse(Console.ReadLine());
string pattern = Console.ReadLine();
string[] splitPattern = pattern.Split('*');

for (int i = 0; i < n; i++)
{
    string inputStr = Console.ReadLine();

    if (splitPattern[0].Length + splitPattern[1].Length > inputStr.Length)
    {
        Console.WriteLine("NE");
    }
    else if (inputStr.StartsWith(splitPattern[0]) && inputStr.EndsWith(splitPattern[1]))
    {
        Console.WriteLine("DA");
    }
    else
    {
        Console.WriteLine("NE");
    }
} 