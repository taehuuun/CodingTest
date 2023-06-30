float weight = float.Parse(Console.ReadLine());
float height = float.Parse(Console.ReadLine());

float BMI = weight / (height * height);

if (BMI > 25.0f)
{
    Console.WriteLine("Overweight");
}
else if (BMI >= 18.5f && BMI <= 25.0f)
{
    Console.WriteLine("Normal weight");
}
else
{
    Console.WriteLine("Underweight");
}