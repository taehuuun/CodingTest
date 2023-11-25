int t = int.Parse(Console.ReadLine());

int[] KMEFS = new int[5];

string[] input = Console.ReadLine().Split(' ');

int[] classNumber =  new int[3];
int result = 0;

for (int i = 0; i < t; i++)
{
    KMEFS[i] = int.Parse(input[i]);
}

if (KMEFS[0] > KMEFS[2])
{
    classNumber[0] = Math.Abs(KMEFS[2] - KMEFS[0]) * 508;
}
else
{
    classNumber[0] = Math.Abs(KMEFS[2] - KMEFS[0]) * 108;
}

if (KMEFS[1] > KMEFS[3])
{
    classNumber[1] = Math.Abs(KMEFS[3] - KMEFS[1]) * 212;
}
else
{
    classNumber[1] = Math.Abs(KMEFS[3] - KMEFS[1]) * 305;
}

if (KMEFS[4] > 0)
{
    classNumber[2] = KMEFS[4] * 707;
}

for (int i = 0; i < classNumber.Length; i++)
{
    result += classNumber[i];
}

result *= 4763;

Console.WriteLine(result);