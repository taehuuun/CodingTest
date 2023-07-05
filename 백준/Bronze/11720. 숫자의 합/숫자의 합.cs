int n = int.Parse(Console.ReadLine());
string input = Console.ReadLine();

int sum = 0;

for (int i = 0; i < input.Length; i++)
{
    sum += input[i] - '0';
}

Console.WriteLine(sum);