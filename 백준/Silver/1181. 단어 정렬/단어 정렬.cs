int n = int.Parse(Console.ReadLine());

List<string> inputList = new List<string>();

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (!inputList.Contains(input))
    {
        inputList.Add(input);
    }
}

inputList.Sort((s, s1) =>
{
    if (s.Length != s1.Length)
    {
        return s.Length.CompareTo(s1.Length);
    }

    return String.Compare(s, s1, StringComparison.Ordinal);
});

foreach (var input in inputList)
{
    Console.WriteLine(input);
}