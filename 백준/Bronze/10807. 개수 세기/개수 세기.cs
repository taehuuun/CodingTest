int n  = int.Parse(Console.ReadLine());
string nums = Console.ReadLine();
string v = Console.ReadLine();

string[] splitNums = nums.Split(' ');

int count = 0;

for (int i = 0; i < splitNums.Length; i++)
{
    if (splitNums[i] == v)
    {
        count++;
    }
}

Console.WriteLine(count);