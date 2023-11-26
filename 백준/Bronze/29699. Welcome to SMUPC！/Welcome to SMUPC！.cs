string str = "WelcomeToSMUPC";

int idx = int.Parse(Console.ReadLine())-1;

Console.WriteLine(str[idx % 14]);