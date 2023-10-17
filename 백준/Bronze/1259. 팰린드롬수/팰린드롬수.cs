while (true)
{
    string input = Console.ReadLine();

    if (input == "0")
    {
        return;
    }

    Console.WriteLine($"{(input== new string(input.Reverse().ToArray()) ? "yes" : "no")}");
}