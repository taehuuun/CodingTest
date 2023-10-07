string input = Console.ReadLine();
bool[] result = new bool[5];

if (input.Length < 5)
{
    Console.WriteLine("NO");
    return;
}

for (int i = 0; i < input.Length; i++)
{
    switch (input[i])
    {
        case 'M':
            result[0] = true;
            break;
        case 'O':
            result[1] = true;
            break;
        case 'B':
            result[2] = true;
            break;
        case 'I':
            result[3] = true;
            break;
        case 'S' :
            result[4] = true;
            break;
    }
}

for (int i = 0; i < result.Length; i++)
{
    if (!result[i])
    {
        Console.WriteLine("NO");
        return;
    }
}

Console.WriteLine("YES");