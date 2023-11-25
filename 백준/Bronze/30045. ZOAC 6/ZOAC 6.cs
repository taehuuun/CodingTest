int n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (input.Contains("01") || input.Contains("OI"))
    {
        count++;
    }
}

Console.WriteLine(count);