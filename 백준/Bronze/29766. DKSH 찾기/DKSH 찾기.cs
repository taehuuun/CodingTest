string input = Console.ReadLine();

input = input.Replace("DKSH", ",");

string[] split = input.Split(',');

Console.WriteLine(split.Length-1);