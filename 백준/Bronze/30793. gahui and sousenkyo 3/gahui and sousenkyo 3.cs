int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

float result = (float)input[0] / input[1];

if (result < 0.2f)
{
    Console.WriteLine("weak");
}
else if (0.2f <= result && result < 0.4f)
{
    Console.WriteLine("normal");

}
else if (0.4f <= result && result < 0.6f)
{
    Console.WriteLine("strong");

}
else
{
    Console.WriteLine("very strong");
}