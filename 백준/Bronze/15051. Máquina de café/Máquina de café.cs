int[] floor = new int[3];

for (int i = 0; i < floor.Length; i++)
{
    floor[i] = int.Parse(Console.ReadLine());
}

int case1 = floor[1] * 2 + floor[2] * 4;
int case2 = floor[0] * 2 + floor[2] * 2;
int case3 = floor[0] * 4 + floor[1] * 2;

Console.WriteLine(Math.Min(case1,Math.Min(case2,case3)));