int appleSum = 0;
int bananaSum = 0;

for (int i = 3; i >0;  i--)
{
    appleSum += int.Parse(Console.ReadLine()) * i;
}

for (int i = 3; i >0;  i--)
{
    bananaSum += int.Parse(Console.ReadLine()) * i;
}

if (appleSum == bananaSum)
{
    Console.WriteLine("T");
}
else if (appleSum > bananaSum)
{
    Console.WriteLine("A");
}
else
{
    Console.WriteLine("B");
}