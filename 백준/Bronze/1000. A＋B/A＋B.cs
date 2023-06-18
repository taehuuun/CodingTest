// 문자열의 형태로 입력을 받는다
string input = Console.ReadLine();

// 입력된 문자열을 공백(' ')을 기준으로 나눈다
string[] splitInput = input.Split(' ');

// 나눈 문자열의 0번째 값 정수형으로 파싱 후 a로 대입
int a = int.Parse(splitInput[0]);

// 나눈 문자열의 1번째 값 정수형으로 파싱 후 b로 대입
int b = int.Parse(splitInput[1]);

// a+b 값을 화면에 출력
Console.WriteLine(a+b);