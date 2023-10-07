string input = Console.ReadLine();

switch (input)
{
    case "fdsajkl;":
    case "jkl;fdsa":
        Console.WriteLine("in-out");
        break;
    case "asdf;lkj":
    case ";lkjasdf":
        Console.WriteLine("out-in");
        break;
    case "asdfjkl;":
        Console.WriteLine("stairs");
        break;
    case ";lkjfdsa":
        Console.WriteLine("reverse");
        break;
    default:
        Console.WriteLine("molu");
        break;
}