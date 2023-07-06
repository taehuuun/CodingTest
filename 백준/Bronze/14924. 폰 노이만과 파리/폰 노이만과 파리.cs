string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

// 50 75 200
int s = int.Parse(splitInput[0]);
int t = int.Parse(splitInput[1]);
int d = int.Parse(splitInput[2]);

int trainMeetTime = d / (s *2);
int distanceFly = trainMeetTime * t;

Console.WriteLine(distanceFly);