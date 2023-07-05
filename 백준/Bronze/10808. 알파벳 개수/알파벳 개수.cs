int[] alphabet = new int [26];

string input =Console.ReadLine();

for (int i = 0; i < input.Length; i++)
{
    alphabet[input[i] - 'a']++;
}

Console.WriteLine(string.Join(" ",alphabet));