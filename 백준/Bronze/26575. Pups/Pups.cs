int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    double result = double.Parse(splitInput[0]) * double.Parse(splitInput[1]) * double.Parse(splitInput[2]);
    result = Math.Round(result, 2);
    
    Console.WriteLine($"${result:F2}");
}