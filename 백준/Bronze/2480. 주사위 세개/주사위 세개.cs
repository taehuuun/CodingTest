string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

List<int> dices = new List<int>();

int result = 0;

for (int i = 0; i < splitInput.Length; i++)
{
    dices.Add(int.Parse(splitInput[i]));
}

dices.Sort();

if (dices[0] == dices[1] && dices[1] == dices[2])
{
    result += 10000 + dices[0] * 1000;
}
else if (dices[0] == dices[1] || dices[1] == dices[2] || dices[0] == dices[2])
{
    result += 1000 + dices[1] * 100;
}
else
{
    result += dices[2] * 100;
}

Console.WriteLine(result);