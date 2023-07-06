string inputReadyMeal = Console.ReadLine();
string inputRequestMeal = Console.ReadLine();

string[] splitReadyMeal = inputReadyMeal.Split(' ');
string[] splitRequestMeal = inputRequestMeal.Split(' ');

int notReceivePassengers = 0;

for (int i = 0; i < 3; i++)
{
    int curReady = int.Parse(splitReadyMeal[i]);
    int curRequest = int.Parse(splitRequestMeal[i]);

    if (curReady < curRequest)
    {
        notReceivePassengers += curRequest - curReady;
    }
}

Console.WriteLine(notReceivePassengers);