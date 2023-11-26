Dictionary<string, string> dictionary = new ()
{
    {"Algorithm", "204"},
    {"DataAnalysis", "207" },
    {"ArtificialIntelligence", "302"},
    {"CyberSecurity", "B101"},
    {"Network", "303"},
    {"Startup", "501"},
    {"TestStrategy", "105"},
};

int n = int.Parse(Console.ReadLine());

for (int i = 0; i < n; i++)
{
    Console.WriteLine(dictionary[Console.ReadLine()]);
}