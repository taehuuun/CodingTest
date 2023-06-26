string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int hour = int.Parse(splitInput[0]);

if (splitInput[1] == "0" && hour >= 12 && hour <= 16)
{
    Console.WriteLine("320");
}
else
{
    Console.WriteLine("280");
}