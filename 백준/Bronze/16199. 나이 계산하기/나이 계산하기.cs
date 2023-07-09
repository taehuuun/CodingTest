int[] birth = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);
int[] today = Array.ConvertAll(Console.ReadLine().Split(),int.Parse);

int birthMon = birth[1];
int todayMon = today[1];
int birthDay = birth[2];
int todayDay = today[2];

int annual = today[0] - birth[0];
int count = annual + 1;
int america = todayMon > birthMon || todayMon == birthMon &&todayDay >= birthDay ? count - 1 : count-2;

Console.WriteLine(america.ToString());
Console.WriteLine(count.ToString());
Console.WriteLine(annual.ToString());