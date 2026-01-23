var sr = new StreamReader(Console.OpenStandardInput());

int n = int.Parse(sr.ReadLine());

for (int i = 0; i < n; i++)
{
    int materialCount = int.Parse(sr.ReadLine());
    int[] criteria = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);

    for (int j = 0; j < materialCount; j++)
    {
        int[] materials = Array.ConvertAll(sr.ReadLine().Split(), int.Parse);
    }

    Console.WriteLine($"Material Management {i+1}");
    Console.WriteLine("Classification ---- End!");
}