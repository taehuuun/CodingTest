// 문자열 타입으로 입력 값을 받음
string input = Console.ReadLine();

// 입력된 문자열을 공백을 기준으로 나눔
string[] splitInput = input.Split(' '); 

// long형으로 타입을 파싱후 n, m에 대입
long n = long.Parse(splitInput[0]);
long m = long.Parse(splitInput[1]);

// n - m 연산을 한 값의 절댓값을 출력함
Console.WriteLine(Math.Abs(n-m));