string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

List<int> list = new List<int>();

for (int i = 0; i < splitInput.Length; i++)
{
    list.Add(int.Parse(splitInput[i]));
}

list.Sort();

if ((list[0] == list[1] || list[0] == list[2] || list[1] == list[2]) || (list[0] + list[1] == list[2]))
{
    Console.WriteLine("S");
}
else
{
    Console.WriteLine("N");
}