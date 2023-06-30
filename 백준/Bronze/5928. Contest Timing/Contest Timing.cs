string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int d = int.Parse(splitInput[0]);
int h = int.Parse(splitInput[1]);
int m = int.Parse(splitInput[2]);

int startMinute = 16511;
int endMinute = d * 60*24 + h * 60 + m;

if (endMinute - startMinute < 0)
{
    Console.WriteLine("-1");
}
else
{
    Console.WriteLine(endMinute-startMinute);
}