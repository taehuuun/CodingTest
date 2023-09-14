int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int apple = input[0] * 7;
int pear = input[1] * 13;

if (apple > pear)
{
    Console.WriteLine("Axel");
}
else if (apple == pear)
{
    Console.WriteLine("lika");
}
else
{
    Console.WriteLine("Petra");
}