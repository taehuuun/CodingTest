string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int n = int.Parse(splitInput[0]);
int c = int.Parse(splitInput[1]);

Dictionary<string, int> dictionary = new Dictionary<string, int>();

string inputNum = Console.ReadLine();
string[] splitNum = inputNum.Split(' ');

for (int i = 0; i < splitNum.Length; i++)
{
    if (!dictionary.ContainsKey(splitNum[i]))
    {
        dictionary.Add(splitNum[i],1);
    }
    else
    {
        dictionary[splitNum[i]]++;
    }
}

var sortedDic = dictionary
    .OrderByDescending(pair => pair.Value)
    .ThenBy(pair => dictionary.ToList().IndexOf(pair))
    .ToDictionary(pair => pair.Key, pair => pair.Value);

foreach (var pair in sortedDic)
{
    for (int i = 0; i < pair.Value; i++)
    {
        Console.Write($"{pair.Key} ");
    }
}