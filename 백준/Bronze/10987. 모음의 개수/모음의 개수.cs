string input = Console.ReadLine();
int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'a' || input[i] == 'e' || input[i] == 'i' || input[i] == 'o' || input[i] == 'u')
    {
        count++;
    }
}

Console.WriteLine(count);

