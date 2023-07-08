using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())) {AutoFlush = true};
StringBuilder sb = new StringBuilder();
int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
    sb.AppendLine((inputs[0] + inputs[1]).ToString());
}

sw.WriteLine(sb.ToString());