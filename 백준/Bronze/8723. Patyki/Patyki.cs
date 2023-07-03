// 가장 긴 변의 길이는 다른 두 변의 합보다 작아야 함
string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

List<int> list = new List<int>();

for (int i = 0; i < splitInput.Length; i++)
{
    list.Add(int.Parse(splitInput[i]));
}

list.Sort();

if (list[0] == list[1] && list[1] == list[2] && list[0] == list[2])
{
    Console.WriteLine("2");
}
else if (Math.Pow(list[2],2) == Math.Pow(list[0],2) + Math.Pow(list[1],2))
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}