byte[] abc = Array.ConvertAll(Console.ReadLine().Split(), byte.Parse);

byte max = abc.Max();
int count = 0;

for (int i = 0; i < abc.Length; i++)
{
    if (abc[i] != max)
    {
        count += max - abc[i];
    }
}

Console.WriteLine(count);