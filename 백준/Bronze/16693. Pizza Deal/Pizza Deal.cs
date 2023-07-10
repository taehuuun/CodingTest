int[] slicePizza = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] circlePizza = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

double circlePizzaOneDollar = Math.Pow(circlePizza[0], 2) * Math.PI / circlePizza[1];
double slicePizzaOneDollar = (double)slicePizza[0] / slicePizza[1];

Console.WriteLine(circlePizzaOneDollar > slicePizzaOneDollar ? "Whole pizza" : "Slice of pizza");