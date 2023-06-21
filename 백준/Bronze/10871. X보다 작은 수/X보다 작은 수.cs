string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

List<int> numList = new List<int>();

int n = int.Parse(splitInput[0]);
int x = int.Parse(splitInput[1]);

string inputNums = Console.ReadLine();
string[] splitInputNums = inputNums.Split(' ');

for (int i = 0; i < splitInputNums.Length; i++)
{
    int num = int.Parse(splitInputNums[i]);

    if (num < x)
    {
        numList.Add(num);
    }
}

Console.WriteLine(string.Join(" ",numList));