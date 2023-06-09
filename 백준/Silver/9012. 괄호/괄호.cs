int t = int.Parse(Console.ReadLine());


for (int i = 0; i < t; i++)
{
    Stack<char> stack = new Stack<char>();
    string input = Console.ReadLine();

    for (int j = 0; j < input.Length; j++)
    {
        if (stack.Count == 0)
        {
            stack.Push(input[j]);
        }
        else
        {
            if (stack.Peek() == '(' && input[j] == ')')
            {
                stack.Pop();
            }
            else
            {
                stack.Push(input[j]);
            }
        }
    }

    if (stack.Count == 0)
    {
        Console.WriteLine("YES");
    }
    else
    {
        Console.WriteLine("NO");
    }
}