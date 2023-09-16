int tugriks = int.Parse(Console.ReadLine());

float commission = Math.Clamp((float)(tugriks * 0.01 + 25),100,2000);

Console.WriteLine($"{commission:0.00}");