var sr = new StreamReader(Console.OpenStandardInput());
var input = string.Empty;

while (true)
{
    input = sr.ReadLine();

    switch (input)
    {
        case "animal":
            Console.WriteLine("Panthera tigris");
            break;
        case "flower":
            Console.WriteLine("Forsythia koreana");
            break;
        case "tree":
            Console.WriteLine("Pinus densiflora");
            break;
        case "end":
            return;
    }
}