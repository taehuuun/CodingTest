using System.Diagnostics;

while (true)
{
    var inputStr = Console.ReadLine();

    if (inputStr == ".")
    {
        return;
    }

    Stack<char> stack = new Stack<char>();

    inputStr = inputStr.Replace(" ", string.Empty);
    inputStr = inputStr.Replace(".", string.Empty);

    if (inputStr.Length == 0)
    {
        Console.WriteLine("yes");
        continue;
    }

    for (int i = 0; i < inputStr.Length; i++)
    {
        if ((stack.Count > 0) && ((stack.Peek() == '(' && inputStr[i] == ')') ||
                                  (stack.Peek() == '[' && inputStr[i] == ']')))
        {
            stack.Pop();
        }
        else if (inputStr[i] == '(' || inputStr[i] == '[' || inputStr[i] == ']' || inputStr[i] == ')')
        {
            stack.Push(inputStr[i]);
        }
    }
    
    if (stack.Count == 0 || string.IsNullOrEmpty(inputStr))
    {
        Console.WriteLine("yes");
    }
    else
    {
        Console.WriteLine("no");
    }
}