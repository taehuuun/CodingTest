int n = int.Parse(Console.ReadLine());

string[] check =
{
    "Never gonna give you up",
    "Never gonna let you down",
    "Never gonna run around and desert you",
    "Never gonna make you cry",
    "Never gonna say goodbye",
    "Never gonna tell a lie and hurt you",
    "Never gonna stop",
};

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    for (int j = 0; j < check.Length; j++)
    {
        if (!check.Contains(input))
        {
            Console.WriteLine("Yes");
            return;
        }
    }
}

Console.WriteLine("No");