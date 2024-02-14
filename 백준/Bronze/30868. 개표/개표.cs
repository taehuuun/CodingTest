int n = int.Parse(Console.ReadLine());

string cross = "++++";
string stick = "|";

for (int i = 0; i < n; i++)
{
    int number = int.Parse(Console.ReadLine());

    int crossCnt = number / 5;
    int stickCnt = number % 5;

    for (int j = 0; j < crossCnt; j++)
    {
        Console.Write($"{cross} ");
    }

    for (int j = 0; j < stickCnt; j++)
    {
        Console.Write(stick);
    }

    Console.WriteLine();
}