int z = int.Parse(Console.ReadLine());

for (int i = 0; i < z; i++)
{
    string input = Console.ReadLine();
    string[] splitInput = input.Split(' ');

    int roomSize = int.Parse(splitInput[0]) * int.Parse(splitInput[1]);
    
    Console.WriteLine(roomSize/2);
}