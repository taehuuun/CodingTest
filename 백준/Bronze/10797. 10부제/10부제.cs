string n = Console.ReadLine();

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int cnt = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    if (splitInput[i] == n)
        cnt++;
}

Console.WriteLine(cnt);