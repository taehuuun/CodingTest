// S = (R1+R2) / 2
// S = (R1+x)/2
// 2S = R1+x
// 2S - R1 = x

string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

int r1 = int.Parse(splitInput[0]);
int s = int.Parse(splitInput[1]);

Console.WriteLine(2*s-r1);