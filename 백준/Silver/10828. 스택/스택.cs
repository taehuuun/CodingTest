using System.Text;

int n = int.Parse(Console.ReadLine());

StringBuilder sb = new StringBuilder();
Stack<int> stack = new Stack<int>();

for (int i = 0; i < n; i++)
{
    string command = Console.ReadLine();

    if (command.Contains(' '))
    {
        string[] split = command.Split(' ');
        ExecuteHandler(split[0], int.Parse(split[1]));
    }
    else
    {
        ExecuteHandler(command);
    }
}

Console.WriteLine(sb);

void ExecuteHandler(string command, int value = 0)
{
    switch (command)
    {
        case "push":
            ExecutePush(value);
            break;
        case "pop":
            ExecutePop();
            break;
        case "size":
            ExecuteSize();
            break;
        case "empty":
            ExecuteEmpty();
            break;
        case "top":
            ExecuteTop();
            break;
    }
}

void ExecutePush(int value = 0)
{
    stack.Push(value);
}

void ExecutePop()
{
    sb.AppendLine($"{(stack.Count == 0 ? "-1" : stack.Pop())}");
}

void ExecuteSize()
{
    sb.AppendLine(stack.Count.ToString());
}

void ExecuteEmpty()
{
    sb.AppendLine($"{(stack.Count == 0 ? "1" : "0")}");
}

void ExecuteTop()
{
    sb.AppendLine($"{(stack.Count == 0 ? "-1" : stack.Peek())}");
}