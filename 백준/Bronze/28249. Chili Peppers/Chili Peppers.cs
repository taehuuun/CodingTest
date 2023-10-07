int n = int.Parse(Console.ReadLine());

int shu = 0;

for (int i = 0; i < n; i++)
{
    string input = Console.ReadLine();

    if (input == "Poblano")
    {
        shu += 1500;
    }
    else if (input == "Mirasol")
    {
        shu += 6000;
    }
    else if (input == "Serrano")
    {
        shu += 15500;
    }
    else if (input == "Cayenne")
    {
        shu += 40000;
    }
    else if (input == "Thai")
    {
        shu += 75000;
    }
    else
    {
        shu += 125000;
    }
}

Console.WriteLine(shu);