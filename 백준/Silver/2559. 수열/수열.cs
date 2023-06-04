// 각 구간 합을 구해본다
List<int> pSum = new List<int>();
List<int> temperature = new List<int>();

string inputNK = Console.ReadLine();
string[] splitNK = inputNK.Split(' ');
int n = int.Parse(splitNK[0]);
int k = int.Parse(splitNK[1]);

string inputTemp = Console.ReadLine();
string[] splitTemp = inputTemp.Split(' ');

int max = int.MinValue;

for (int i = 0; i < splitTemp.Length; i++)
{
    temperature.Add(int.Parse(splitTemp[i]));
}

pSum.Add(0);

for (int i = 0; i < temperature.Count; i++)
{
    pSum.Add(pSum[i] + temperature[i]);
}


if (n == k)
{
    max = pSum[pSum.Count - 1];
}

for (int i = 1; i < temperature.Count - k+2; i++)
{
    int curSum = pSum[i + k-1] - pSum[i-1];

    max = curSum > max ? curSum : max;
}

Console.WriteLine(max);