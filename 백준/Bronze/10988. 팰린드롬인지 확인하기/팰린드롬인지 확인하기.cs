string input = Console.ReadLine();
string reverse = new string(input.Reverse().ToArray());

Console.WriteLine((input == reverse) ? "1" : "0");