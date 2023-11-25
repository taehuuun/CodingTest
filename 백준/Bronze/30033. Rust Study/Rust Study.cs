int n = int.Parse(Console.ReadLine());

int[] planPage = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] studyPage = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

int count = 0;

for (int i = 0; i < n; i++)
{
    if (planPage[i] <= studyPage[i])
    {
        count++;
    }
}

Console.WriteLine(count);