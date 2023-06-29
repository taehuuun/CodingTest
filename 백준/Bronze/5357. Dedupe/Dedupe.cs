int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();
    string result = "";
    Stack<char> stack = new Stack<char>();

    stack.Push(input[0]);
    result += input[0];
    
    for (int j = 1; j < input.Length; j++)
    {
        if (stack.Peek() != input[j])
        {
            result += input[j];
            stack.Push(input[j]);
        }
    }
    
    Console.WriteLine(result);
}