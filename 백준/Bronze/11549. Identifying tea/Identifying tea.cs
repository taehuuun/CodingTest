string answer = Console.ReadLine();
string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int result = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    if (splitInput[i] == answer)
    {
        result++;
    }
}

Console.WriteLine(result);