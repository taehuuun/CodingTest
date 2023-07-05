int t = int.Parse(Console.ReadLine());

for (int i = 0; i < t; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    string result = splitInput[0] == splitInput[1] ? "OK" : "ERROR"; 
    Console.WriteLine(result);    
}