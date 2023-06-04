Dictionary<int, string> intKeyCollection = new Dictionary<int, string>();
Dictionary<string, int> stringKeyCollection = new Dictionary<string, int>();

using var sr = new StreamReader(Console.OpenStandardInput());
using var sw = new StreamWriter(Console.OpenStandardOutput());

string inputNM = sr.ReadLine();
string[] splitNM = inputNM.Split(' ');
int n = int.Parse(splitNM[0]);
int m = int.Parse(splitNM[1]);

for (int i = 1; i <= n; i++)
{
    string inputPoketmon = sr.ReadLine();
    intKeyCollection.Add(i, inputPoketmon);
    stringKeyCollection.Add(inputPoketmon, i);
}

for (int i = 0; i < m; i++)
{
    string input = sr.ReadLine();
    int num = 0;

    if (int.TryParse(input, out num))
    {
        sw.WriteLine(intKeyCollection[num]);
    }
    else
    {
        sw.WriteLine(stringKeyCollection[input]);
    }
}

sw.Flush();