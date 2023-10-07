int[] input = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int targetFloor = input[0];
int curElevatorFloor = input[1];
int stairPerFloorTime = input[2];
int elevatorPerFloorTime = input[3];

int stairTotalTime = (targetFloor - 1) * stairPerFloorTime;
int elevatorTotalTime = ((curElevatorFloor - 1) * elevatorPerFloorTime) + ((targetFloor-1) * elevatorPerFloorTime);

Console.WriteLine($"{elevatorTotalTime} {stairTotalTime}");