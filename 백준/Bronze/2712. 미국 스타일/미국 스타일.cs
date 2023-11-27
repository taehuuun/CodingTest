int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    string[] input = Console.ReadLine().Split(' ');

    float value = float.Parse(input[0]);
    float convertValue = 0f;
    string unit = input[1];

    switch (unit)
    {
        case "kg":
            convertValue = value * 2.2046f;
            unit = "lb";
            break;
        case "l":
            convertValue = value * 0.2642f;
            unit = "g";
            break;
        case "lb":
            convertValue = value * 0.4536f;
            unit = "kg";
            break;
        case "g":
            convertValue = value * 3.7854f;
            unit = "l";
            break;
    }
    Console.WriteLine($"{convertValue:F4} {unit}");
}