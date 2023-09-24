string input = Console.ReadLine();
string answer = string.Empty;

answer += input[0];

for (int i = input[0] - 64; i < input.Length;)
{
    answer += input[i];
    i += input[i] - 64;
}

Console.WriteLine(answer);