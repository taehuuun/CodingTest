int n = int.Parse(Console.ReadLine());

Console.WriteLine("Gnomes: ");

for (int i = 0; i < n; i++)
{
    List<int> numList = new List<int>();
    List<int> numList2 = new List<int>();
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    for (int j = 0; j < splitInput.Length; j++)
    {
        numList.Add(int.Parse(splitInput[j]));
    }
    
    numList.Sort();
    numList2 = numList.OrderByDescending(x => x).ToList();
    
    if (input == string.Join(" ", numList) || input == string.Join(" ", numList2))
    {
        Console.WriteLine("Ordered");
    }
    else
    {
        Console.WriteLine("Unordered");
    }
}