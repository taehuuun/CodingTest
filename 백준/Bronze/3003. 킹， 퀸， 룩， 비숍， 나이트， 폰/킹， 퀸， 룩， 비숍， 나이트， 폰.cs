// 원래 체스의 각 피스 개수 배열
int[] chess = {1,1,2,2,2,8};

// 문자열의 형태로 입력을 받음
string input = Console.ReadLine();

// 공백을 기준으로 input을 나눔
string[] splitInput = input.Split(' ');

// splitInput의 길이 만큼 반복
for (int i = 0; i < splitInput.Length; i++)
{
    // chess[i]에 해당하는 값을 정수형으로 변환한 splitInput[i] 값을 빼서 대입
    chess[i] -= int.Parse(splitInput[i]);
}

// 연산이 끝난 chess 배열을 출력
Console.WriteLine(string.Join(" ",chess));