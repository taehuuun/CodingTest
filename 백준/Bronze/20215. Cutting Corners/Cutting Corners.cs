int[] inputs = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

double answer = inputs[0] + inputs[1] - Math.Sqrt(Math.Pow(inputs[0],2) + Math.Pow(inputs[1],2));

Console.WriteLine($"{answer:0.#########}");