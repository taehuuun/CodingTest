int[] diary = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);
int[] fontSize = Array.ConvertAll(Console.ReadLine().Split(' '), int.Parse);

if (diary[0] < fontSize[1] || diary[1] < fontSize[2])
{
    Console.WriteLine(-1);
}
else
{
    int x = diary[0] / fontSize[1];
    int y = diary[1] / fontSize[2];
    int page =(int)MathF.Ceiling((float)fontSize[0] / (x * y)) ;

    Console.WriteLine(page);
}