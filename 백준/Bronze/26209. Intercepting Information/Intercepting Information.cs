string input = Console.ReadLine();
string[] splitInput = input.Split(' ');

Console.WriteLine(splitInput.Contains("9") ? "F" : "S");