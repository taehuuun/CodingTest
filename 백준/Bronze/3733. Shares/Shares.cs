using System.Numerics;

List<string> inputList = new List<string>();

while (true)
{
    var input = Console.ReadLine();
    
    if (string.IsNullOrEmpty(input))
    {
        break;        
    }
    
    inputList.Add(input);
}

for (int i = 0; i < inputList.Count; i++)
{
    string[] splitInput = inputList[i].Split(' ');
    int n = int.Parse(splitInput[0]);
    int s = int.Parse(splitInput[1]);

    Console.WriteLine(s/ (n + 1));
}