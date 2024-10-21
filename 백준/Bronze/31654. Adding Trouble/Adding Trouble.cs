int[] inputs =  Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

if (inputs[0] + inputs[1] == inputs[2])
{
    Console.WriteLine("correct!");
}
else
{
    Console.WriteLine("wrong!");
}