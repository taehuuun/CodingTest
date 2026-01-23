var sr = new StreamReader(Console.OpenStandardInput());

switch (sr.ReadLine()[0])
{
    case 'F':
        Console.WriteLine("Foundation");
        break;
    case 'C':
        Console.WriteLine("Claves");
        break;
    case 'V':
        Console.WriteLine("Veritas");
        break;
    case 'E':
        Console.WriteLine("Exploration");
        break;
}