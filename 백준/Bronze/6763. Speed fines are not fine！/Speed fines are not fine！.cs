int limitSpeed = int.Parse(Console.ReadLine());
int currentSpeed = int.Parse(Console.ReadLine());

if (currentSpeed <= limitSpeed)
{
    Console.WriteLine("Congratulations, you are within the speed limit!");
}
else
{
    int overSpeed = currentSpeed - limitSpeed;
    int fine = 0;
    
    if (overSpeed >= 1 && overSpeed <= 20)
    {
        fine = 100;
    }
    else if (overSpeed >= 21 && overSpeed <= 30)
    {
        fine = 270;
    }
    else
    {
        fine = 500;
    }
    
    Console.WriteLine($"You are speeding and your fine is ${fine}.");
}