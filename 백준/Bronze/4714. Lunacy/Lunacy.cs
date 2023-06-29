while (true)
{
    float input = float.Parse(Console.ReadLine());

    if (input < 0)
    {
        return;
    }
    
    Console.WriteLine($"Objects weighing {input:0.00} on Earth will weigh {(input * 0.167):0.00} on the moon.");
}