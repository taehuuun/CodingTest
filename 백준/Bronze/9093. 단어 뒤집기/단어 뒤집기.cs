int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] split = input.Split(' ');

    for (int j = 0; j < split.Length; j++)
    {
        split[j] = new string(split[j].Reverse().ToArray());
    }
    
    Console.WriteLine(string.Join(" ",split));
}