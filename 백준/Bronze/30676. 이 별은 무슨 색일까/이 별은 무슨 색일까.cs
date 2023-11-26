int wave = int.Parse(Console.ReadLine());

if (wave is >= 620 and <= 780)
{
    Console.WriteLine("Red");
}
else if (wave is >= 590 and < 620)
{
    Console.WriteLine("Orange");
}
else if (wave is >= 570 and < 590)
{
    Console.WriteLine("Yellow");
}
else if (wave is >= 495 and < 570)
{
    Console.WriteLine("Green");
}
else if (wave is >= 450 and < 495)
{
    Console.WriteLine("Blue");
}
else if (wave is >= 425 and < 450)
{
    Console.WriteLine("Indigo");
}
else
{
    Console.WriteLine("Violet");
}