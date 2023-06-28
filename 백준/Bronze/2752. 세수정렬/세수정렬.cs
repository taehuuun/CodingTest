string input = Console.ReadLine();
string[] splitInput = input.Split(' ');
List<int> numList = new List<int>();

for (int i = 0; i < splitInput.Length; i++)
{
    numList.Add(int.Parse(splitInput[i]));
}

numList.Sort();
Console.WriteLine(string.Join(" ", numList));