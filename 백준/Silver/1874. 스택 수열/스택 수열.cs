using (StreamReader sr = new StreamReader(Console.OpenStandardInput()))
using (StreamWriter sw = new StreamWriter(Console.OpenStandardOutput()) { AutoFlush = true })
{
    int n = int.Parse(sr.ReadLine());
    int[] targetSequence = new int[n];

    for (int i = 0; i < n; i++)
    {
        targetSequence[i] = int.Parse(sr.ReadLine());
    }

    string result = GetStackOperations(targetSequence);

    if (result != null)
    {
        sw.Write(result);
    }
    else
    {
        sw.WriteLine("NO");
    }
}

static string GetStackOperations(int[] targetSequence)
{
    char[] operations = new char[targetSequence.Length * 4];  // 최대 2n의 연산이 필요합니다.
    Stack<int> stack = new Stack<int>(targetSequence.Length);  // 스택의 초기 크기를 설정합니다.
    int currentNumber = 1, opIndex = 0;

    foreach (int target in targetSequence)
    {
        while (currentNumber <= target)
        {
            stack.Push(currentNumber++);
            operations[opIndex++] = '+';
            operations[opIndex++] = '\n';
        }

        if (stack.Count > 0 && stack.Peek() == target)
        {
            stack.Pop();
            operations[opIndex++] = '-';
            operations[opIndex++] = '\n';
        }
        else
        {
            return null;  // Invalid sequence
        }
    }

    return new string(operations, 0, opIndex);
}