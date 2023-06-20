// 문자열 형식으로 입력을 받음
string input = Console.ReadLine();

// 변환된 문자열을 저장할 answer 변수
string answer = "";

// input의 길이 만큼 반복
for (int i = 0; i < input.Length; i++)
{
    // input[i]번째 문자를 curChar에 대입
    char curChar = input[i];
    
    // curChar값이 대문자인지 체크
    // 대문자면 ToLower메서드를 통해 소문자로
    // 소문자면 ToUpper메서드를 통해 대문자로
    answer += char.IsUpper(curChar) ? char.ToLower(input[i]) : char.ToUpper(input[i]);
}

// answer 출력
Console.WriteLine(answer);