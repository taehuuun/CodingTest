int input = int.Parse(Console.ReadLine());
int finger = input % 8;

if (finger == 1)
    Console.WriteLine("1");
else if (finger == 2 || finger == 0)
    Console.WriteLine("2");
else if (finger == 3 || finger == 7)
    Console.WriteLine("3");
else if (finger == 4 || finger == 6)
    Console.WriteLine("4");
else
    Console.WriteLine("5");