using System.Numerics;
using System.Text;

StreamReader streamReader = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
TextWriter stringWriter = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())) { AutoFlush = true };
StringBuilder stringBuilder = new StringBuilder();

int t = int.Parse(streamReader.ReadLine());
for (int i = 0; i < t ; i++)
{
    int n = int.Parse(streamReader.ReadLine());
    stringBuilder.AppendLine(((BigInteger)n * n).ToString());
}

stringWriter.WriteLine(stringBuilder.ToString());