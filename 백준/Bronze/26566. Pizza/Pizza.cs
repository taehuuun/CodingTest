int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    var slice = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
    var circle = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

    int sliceArea = slice[0];
    int slicePrice = slice[1];
    int sliceAreaPrice = sliceArea / slicePrice;
    
    int circleRadius = circle[0];
    int circlePrice = circle[1];
    int circleAreaPrice = (int)(circleRadius* circleRadius * Math.PI / circlePrice);
    
    Console.WriteLine($"{(sliceAreaPrice < circleAreaPrice ? "Whole pizza" : "Slice of pizza")}");
}