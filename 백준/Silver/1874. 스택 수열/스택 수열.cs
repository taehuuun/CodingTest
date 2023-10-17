int n = int.Parse(Console.ReadLine());
int[] targetSequence = new int[n];

for (int i = 0; i < n; i++)
{
    targetSequence[i] = int.Parse(Console.ReadLine());
}

string result = GetStackOperations(targetSequence);

if (result != null)
{
    Console.WriteLine(result);
}
else
{
    Console.WriteLine("NO");
}

static string GetStackOperations(int[] targetSequence)
{
    List<char> operations = new List<char>(targetSequence.Length * 2);  // 최대 2n의 연산이 필요합니다.
    Stack<int> stack = new Stack<int>(targetSequence.Length);  // 스택의 초기 크기를 설정합니다.
    int currentNumber = 1;

    foreach (int target in targetSequence)
    {
        while (currentNumber <= target)
        {
            stack.Push(currentNumber++);
            operations.Add('+');
            operations.Add('\n');
        }

        if (stack.Count > 0 && stack.Peek() == target)
        {
            stack.Pop();
            operations.Add('-');
            operations.Add('\n');
        }
        else
        {
            return null;  // Invalid sequence
        }
    }

    return new string(operations.ToArray());
}