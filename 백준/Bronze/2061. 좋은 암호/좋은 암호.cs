using System.Numerics;

string[] inputs = Console.ReadLine().Split(' ');
BigInteger K = BigInteger.Parse(inputs[0]);
int L = int.Parse(inputs[1]);

// 에라토스테네스의 체로 L보다 작은 소수들 찾기
List<int> primes = SieveOfEratosthenes(L - 1);

foreach (int prime in primes)
{
    if (K % prime == 0)
    {
        Console.WriteLine($"BAD {prime}");
        return;
    }
}

Console.WriteLine("GOOD");

List<int> SieveOfEratosthenes(int limit)
{
    bool[] prime = new bool[limit + 1];
    List<int> primeList = new List<int>();

    for (int i = 2; i <= limit; i++)
    {
        prime[i] = true;
    }

    for (int p = 2; p * p <= limit; p++)
    {
        if (prime[p])
        {
            for (int i = p * p; i <= limit; i += p)
            {
                prime[i] = false;
            }
        }
    }

    for (int p = 2; p <= limit; p++)
    {
        if (prime[p])
        {
            primeList.Add(p);
        }
    }

    return primeList;
}