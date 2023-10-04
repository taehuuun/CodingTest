int n = int.Parse(Console.ReadLine());

for(int i = 0; i < n; i++)
{
    float[] input = Array.ConvertAll(Console.ReadLine().Split(), float.Parse);

    float height = (2 * input[0]) / input[1];
    
    Console.WriteLine($"The height of the triangle is {height:0.00} units");
}
