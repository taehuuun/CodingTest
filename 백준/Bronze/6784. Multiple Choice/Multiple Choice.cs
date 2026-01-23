var sr = new StreamReader(Console.OpenStandardInput());
var n = int.Parse(sr.ReadLine());

string[] questions = new string[n];
string[] answers = new string[n];
int answer = 0;

for (int i = 0; i < n; i++)
{
    questions[i] = sr.ReadLine();
}

for (int i = 0; i < n; i++)
{
    answers[i] = sr.ReadLine();
}

for (int i = 0; i < n; i++)
{
    if (answers[i] == questions[i])
    {
        answer++;
    }
}

Console.WriteLine(answer);