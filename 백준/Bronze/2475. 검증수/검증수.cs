// 문자열 형식으로 입력을 받는다
string input = Console.ReadLine();

// 문자열을 공백을 기준으로 나눈다
string[] splitInput = input.Split(' ');

// 값을 더할 sum 변수
int sum = 0;

// splitInput의 길이 만큼 반복
for (int i = 0; i < splitInput.Length; i++)
{
    // splitInput[i] 값을 정수형으로 파싱
    int num = int.Parse(splitInput[i]);
    
    // 해당 num의 제곱값을 sum에 더함
    sum += (int)Math.Pow(num,2);
}

// sum을 10으로 나눈 나머지를 출력
Console.WriteLine(sum % 10);