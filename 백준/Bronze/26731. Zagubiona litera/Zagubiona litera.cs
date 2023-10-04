char[] input = Console.ReadLine().ToCharArray();
string alphabat = $"ABCDEFGHIJKLMNOPQRSTUVWXYZ";

Array.Sort(input);

string result = string.Empty;

for (int i = 0; i < input.Length; i++)
{
    if (input[i] != alphabat[i])
    {
        result += alphabat[i];
        break;
    }
}

Console.WriteLine($"{(result == string.Empty ? "Z" : result)}");