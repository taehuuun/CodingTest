int[] depths = new int[4];

for (int i = 0; i < depths.Length; i++)
{
    depths[i] = int.Parse(Console.ReadLine());
}

if (depths[0] < depths[1] && depths[1] < depths[2] && depths[2] < depths[3])
{
    Console.WriteLine("Fish Rising");
}
else if (depths[0] > depths[1] && depths[1] > depths[2] && depths[2] > depths[3])
{
    Console.WriteLine("Fish Diving");
}
else if (depths[0] == depths[1] && depths[1] == depths[2] && depths[2] == depths[3])
{
    Console.WriteLine("Fish At Constant Depth");
}
else
{
    Console.WriteLine("No Fish");
}