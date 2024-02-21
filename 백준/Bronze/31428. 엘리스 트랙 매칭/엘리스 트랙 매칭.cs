int n = int.Parse(Console.ReadLine());

string friendInput = Console.ReadLine();
string[] splitInput = friendInput.Split(' ');
string helloBitInput = Console.ReadLine();

int count = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    if (splitInput[i] == helloBitInput)
    {
        count++;
    }
}

Console.WriteLine(count);