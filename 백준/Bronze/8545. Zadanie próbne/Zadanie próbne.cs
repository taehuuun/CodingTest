string input = Console.ReadLine();
string answer = "";

for (int i = input.Length - 1; i >= 0; i--)
{
    answer += input[i];
}

Console.WriteLine(answer);