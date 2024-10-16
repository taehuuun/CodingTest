string input = Console.ReadLine();

int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] == 'e')
    {
        count++;
    }
}

Console.Write("h");

for (int i = 0; i < count*2; i++)
{
    Console.Write("e");
}

Console.Write("y");