string target = Console.ReadLine();
int n = int.Parse(Console.ReadLine());

int count = 0;
string key = target.Substring(0, 5);

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string inputKey = input.Substring(0, 5);

    if (inputKey == key)
    {
        count++;
    }
}

Console.WriteLine(count);