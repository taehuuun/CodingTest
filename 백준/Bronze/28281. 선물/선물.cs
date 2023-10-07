int[] data = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] socks = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int minPrice = int.MaxValue;

for (int i = 0; i < socks.Length-1; i++)
{
    int price = socks[i] * data[1] + socks[i + 1] * data[1];
    minPrice = Math.Min(minPrice, price);
}

Console.WriteLine(minPrice);