using System.Text;

StreamReader sr = new StreamReader(new BufferedStream(Console.OpenStandardInput()));
StringBuilder sb = new StringBuilder();

int n = int.Parse(sr.ReadLine());

using (StreamWriter sw = new StreamWriter(new BufferedStream(Console.OpenStandardOutput())){AutoFlush = true})
{
    for (int i = 0; i < n; i++)
    {
        int[] inputs = Array.ConvertAll(sr.ReadLine().Split(' '), int.Parse);
        sb.AppendLine((inputs[0] + inputs[1]).ToString());
    }

    sw.WriteLine(sb.ToString());
}