// 문자열의 형태로 입력을 받음
string input = Console.ReadLine();

// 입력 받은 문자열을 공백을 기준으로 나눔
string[] splitInput = input.Split(' ');

//  splitInput의 0번재 문자열을 정수형으로 파싱후  a에 대입 
int a = int.Parse(splitInput[0]);

//  splitInput의 1번재 문자열을 정수형으로 파싱후  b에 대입
int b = int.Parse(splitInput[1]);

// 각 값을 비교 하여 결과를 출력
// case1) a < b => "<" 출력
// case2) a > b => ">" 출력
// case3) a < b => "==" 출력
if (a < b)
{
    Console.WriteLine("<");
}
else if (a > b)
{
    Console.WriteLine(">");
}
else
{
    Console.WriteLine("==");
}