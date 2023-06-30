string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int currentHeight = int.Parse(splitInput[0]);
int targetHeight = int.Parse(splitInput[1]);
int growValue = int.Parse(splitInput[2]);

if ((targetHeight - currentHeight) % growValue == 0)
{
    Console.WriteLine((targetHeight - currentHeight) / growValue);
}
else
{
    Console.WriteLine((targetHeight - currentHeight) / growValue + 1);
}