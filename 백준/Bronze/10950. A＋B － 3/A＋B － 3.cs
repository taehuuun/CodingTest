int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    int a = int.Parse(splitInput[0]);
    int b = int.Parse(splitInput[1]);
    
    Console.WriteLine(a+b);
}