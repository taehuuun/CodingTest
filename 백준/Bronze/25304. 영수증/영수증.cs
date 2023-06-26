int total = int.Parse(Console.ReadLine());
int n = int.Parse(Console.ReadLine());

int sum = 0;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    sum += int.Parse(splitInput[0]) * int.Parse(splitInput[1]);
}

Console.WriteLine((sum == total) ? "Yes" : "No");