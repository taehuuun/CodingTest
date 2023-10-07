int success = int.Parse(Console.ReadLine());
int collision = int.Parse(Console.ReadLine());

int point = success > collision ? 500 : 0;

point += success * 50;
point -= collision * 10;

Console.WriteLine(point);