// StringBuilder 사용을 위한 using
using System.Text;

// 정수형으로 입력을 받는다
int n = int.Parse(Console.ReadLine());

StringBuilder stringBuilder = new StringBuilder();

// 1부터 n까지 하나씩 stringBuilder에 Append
for (int i = 1; i <= n; i++)
{
    stringBuilder.Append($"{i}\n");
}

// stringBuilder 출력
Console.WriteLine(stringBuilder.ToString());