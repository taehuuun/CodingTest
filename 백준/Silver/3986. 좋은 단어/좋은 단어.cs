int n = int.Parse(Console.ReadLine());

int count = 0;

for (int i = 0; i < n; i++)
{
    Stack<char> word = new Stack<char>();
    string inputWord = Console.ReadLine();

    for (int j = 0; j < inputWord.Length; j++)
    {
        if (word.Count ==0 || word.Peek() != inputWord[j])
        {
            word.Push(inputWord[j]);
            continue;
        }

        if (word.Peek() == inputWord[j])
        {
            word.Pop();
        }
    }

    if (word.Count == 0)
    {
        count++;
    }
}

Console.WriteLine(count);