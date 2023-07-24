int[] criteria = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);
int[] achieved = Array.ConvertAll(Console.ReadLine().Split(), int.Parse);

int A = criteria[0];
int C = criteria[1];
int E = criteria[2];

int achievedA = achieved[0];
int achievedC = achieved[1];
int achievedE = achieved[2];

if (achievedA == A && achievedC == C && achievedE == E) {
    Console.WriteLine("A");
}
else if (achievedA >= Math.Ceiling((double)A / 2) && achievedC == C && achievedE == E) {
    Console.WriteLine("B");
}
else if (achievedC == C && achievedE == E) {
    Console.WriteLine("C");
}
else if (achievedC >= Math.Ceiling((double)C / 2) && achievedE == E) {
    Console.WriteLine("D");
}
else if (achievedE == E) {
    Console.WriteLine("E");
}