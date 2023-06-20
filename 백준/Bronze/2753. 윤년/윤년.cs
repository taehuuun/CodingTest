// 년도를 정수형으로 입력 받음
int year = int.Parse(Console.ReadLine());

// 4의 배수이면서 100의 배수가 아닐때 또는 400의 배수 일때
if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
{
    Console.WriteLine("1");
}
else
{
    Console.WriteLine("0");
}