int n = int.Parse(Console.ReadLine());
string k =Console.ReadLine();

int oddCount = 0;
int evenCount = 0;

for (int i = 0; i < n; i++)
{
    if ((k[i] -'0') % 2 == 0)
    {
        evenCount++;
    }
    else
    {
        oddCount++;
    }
}

if (evenCount > oddCount)
{
    Console.WriteLine(0);
}
else if (evenCount < oddCount)
{
    Console.WriteLine(1);
}
else
{
    Console.WriteLine(-1);
}
