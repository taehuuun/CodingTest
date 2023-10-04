int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    int start = input[0];
    int time = input[1];
    int result = start - (time/7) + (time/4);
    
    Console.WriteLine(result);
}