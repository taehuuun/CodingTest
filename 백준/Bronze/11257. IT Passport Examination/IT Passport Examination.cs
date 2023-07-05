int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    string id = splitInput[0];
    int strategy = int.Parse(splitInput[1]);
    int control = int.Parse(splitInput[2]);
    int tech = int.Parse(splitInput[3]);
    int total = strategy + control + tech;

    string result = total >= 55 && strategy >= 10.5f && control >= 7.5f && tech >= 12 ? "PASS" : "FAIL";
    
    Console.WriteLine($"{id} {total} {result}");
}