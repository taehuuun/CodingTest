int[] p1 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] p2 = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int player1Score = p1[0] *3 + p1[1];
int player2Score = p2[0] *3 + p2[1];

if (player1Score == player2Score)
{
    Console.WriteLine("NO SCORE");
}
else if (player1Score > player2Score)
{
    Console.WriteLine($"1 {player1Score - player2Score}");
}
else
{
    Console.WriteLine($"2 {player2Score - player1Score}");
}