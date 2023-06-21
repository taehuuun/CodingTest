string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

long sum = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    sum += long.Parse(splitInput[i]);
}

Console.WriteLine(sum);