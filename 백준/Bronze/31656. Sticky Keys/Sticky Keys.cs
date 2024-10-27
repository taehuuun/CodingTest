string str = Console.ReadLine();
string result = string.Empty;

for (int i = 0; i < str.Length -1; i++)
{
    if (str[i] != str[i + 1])
    {
        result += str[i];
        continue;
    }

    for (int j = i + 1; j < str.Length -1; j++)
    {
        if (str[j] != str[j + 1])
        {
            i = j-1;
            break;
        }
    }
}

result += str[str.Length - 1];

Console.WriteLine(result);