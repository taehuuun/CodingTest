string input1 = Console.ReadLine();
string input2 = Console.ReadLine();

string[] splitInput1 = input1.Split(' ');
string[] splitInput2 = input2.Split(' ');

int team1Score = 0;
int team2Score = 0;

team1Score = int.Parse(splitInput1[0]) * 6 + int.Parse(splitInput1[1]) *3 + int.Parse(splitInput1[2]) * 2 + int.Parse(splitInput1[3]) + int.Parse(splitInput1[4]) * 2;
team2Score = int.Parse(splitInput2[0]) * 6 + int.Parse(splitInput2[1]) *3 + int.Parse(splitInput2[2]) * 2 + int.Parse(splitInput2[3]) + int.Parse(splitInput2[4]) * 2;

Console.WriteLine($"{team1Score} {team2Score}");