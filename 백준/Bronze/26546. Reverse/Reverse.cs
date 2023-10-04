int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');
    string str = input[0];
    string result = string.Empty;
    int start = int.Parse(input[1]);
    int end = int.Parse(input[2]);

    for (int j = 0; j < str.Length; j++)
    {
        if(j >= start && j < end)
            continue;

        result += str[j];
    }
    
    Console.WriteLine(result);
}