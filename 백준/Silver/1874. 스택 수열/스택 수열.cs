using System.Text;

int n = int.Parse(Console.ReadLine());
int[] targetSequence = new int[n];

StringBuilder sb = new StringBuilder();
Stack<int> stack = new Stack<int>();
int max = 0;

for (int i = 0; i < targetSequence.Length; i++)
{
    targetSequence[i] = int.Parse(Console.ReadLine());
}

for (int i = 0; i < targetSequence.Length; i++)
{
    int target = targetSequence[i];

    while (true)
    {
        if ((stack.Count == 0 && max < target) || (stack.Count >0 && stack.Peek() < target && max < target))
        {
            sb.AppendLine("+");
            stack.Push(max+1);
            max = Math.Max(stack.Peek(), max);
        }
        else if (stack.Count >0 && stack.Peek() == target)
        {
            sb.AppendLine("-");
            stack.Pop();
            break;
        }
        else if(stack.Count >0 && stack.Peek() > target)
        {
            sb.AppendLine("-");
            stack.Pop();
        }
        else
        {
            Console.WriteLine("NO");
            return;
        }
    }
}

Console.WriteLine(sb);