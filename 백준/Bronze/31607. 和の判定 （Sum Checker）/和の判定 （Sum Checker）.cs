int[] input = new int[3];

for (int i = 0; i < input.Length; i++)
{
    input[i] = int.Parse(Console.ReadLine());
}

if (input[0] + input[1] == input[2] || input[0] + input[2] == input[1] || input[1] + input[2] == input[0])
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}