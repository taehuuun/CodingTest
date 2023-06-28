string input = Console.ReadLine();
string[] splitInput = input.Split(' ');
int pyeong = int.Parse(splitInput[0]);
int population = int.Parse(splitInput[1]);

int populationPerPyeong = population * pyeong;

string inputPopulationBySpace = Console.ReadLine();
string[] splitPopulationBySpace = inputPopulationBySpace.Split(' ');
int[] numPopulationBySpace = new int[5];

for (int i = 0; i < numPopulationBySpace.Length; i++)
{
    numPopulationBySpace[i] = int.Parse(splitPopulationBySpace[i]) - populationPerPyeong;
}

Console.WriteLine(string.Join(" ",numPopulationBySpace));