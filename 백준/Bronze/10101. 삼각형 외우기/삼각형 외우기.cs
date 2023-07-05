int[] angles = new int[30];
int sumAngles = 0;

for (int i = 0; i < 3; i++)
{
    angles[i] = int.Parse(Console.ReadLine());
    sumAngles += angles[i];
}

if (angles[0] == 60 && angles[1] == 60 && angles[2] == 60)
{
    Console.WriteLine("Equilateral");
}
else if (sumAngles != 180)
{
    Console.WriteLine("Error");
}
else
{
    if (angles[0] == angles[1] || angles[1] == angles[2] || angles[0] == angles[2])
    {
        Console.WriteLine("Isosceles");
    }
    else if (angles[0] != angles[1] && angles[1] != angles[2] && angles[0] != angles[2])
    {
        Console.WriteLine("Scalene");
    }
}