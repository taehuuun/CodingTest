string input =Console.ReadLine();
string[] splitInput = input.Split(' ');

int l = int.Parse(splitInput[0]);
int r = int.Parse(splitInput[1]);

if (l == 0 && r == 0)
{
    Console.WriteLine("Not a moose");
    return;
}

if (l == r)
{
    Console.WriteLine($"Even {l+r}");
}
else
{
    Console.WriteLine($"Odd {Math.Max(l,r) *2}");
}