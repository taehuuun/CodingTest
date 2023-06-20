List<int> numList = new List<int>();

for (int i = 0; i < 3; i++)
{
    int num = int.Parse(Console.ReadLine());
    numList.Add(num);
}

numList.Sort();

Console.WriteLine(numList[1]);