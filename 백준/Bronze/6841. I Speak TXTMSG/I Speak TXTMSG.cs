while (true)
{
    string input = Console.ReadLine();
    
    if (input == "TTYL")
    {
        Console.WriteLine("talk to you later");
        return;
    }

    string output = "";
    switch (input)
    {
        case "CU":
            output = "see you";
            break;
        case ":-)":
            output = "I’m happy";
            break;
        case ":-(":
            output = "I’m unhappy";
            break;
        case ";-)":
            output = "wink";
            break;
        case ":-P":
            output = "stick out my tongue";
            break;
        case "(~.~)":
            output = "sleepy";
            break;
        case "TA":
            output = "totally awesome";
            break;
        case "CCC":
            output = "Canadian Computing Competition";
            break;
        case "CUZ":
            output = "because";
            break;
        case "TY":
            output = "thank-you";
            break;
        case "YW":
            output = "you’re welcome";
            break;
        default:
            output = input;
            break;
    }
    
    Console.WriteLine(output);
}