string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int addedScore = int.Parse(splitInput[0]);
int minusScore = int.Parse(splitInput[1]);

if ((addedScore + minusScore) % 2 != 0 || (addedScore - minusScore) % 2 != 0)
{
    Console.WriteLine("-1");
}
else
{
    int a = (addedScore + minusScore) / 2;
    int b = (addedScore - minusScore) / 2;

    if (a >= 0 && b >= 0)
    {
        if (a >= b)
        {
            Console.WriteLine($"{a} {b}");
        }
        else
        {
            Console.WriteLine($"{b} {a}");
        }
    }
    else
    {
        Console.WriteLine("-1");
    }
}