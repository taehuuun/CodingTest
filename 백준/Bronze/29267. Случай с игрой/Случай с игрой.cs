int[] input = Array.ConvertAll(Console.ReadLine().Split(" "), int.Parse);

int commandCount = input[0];
int ammoValue = input[1];

int currentAmmo = 0;
int lastSavedAmmo = 0;

for (int i = 0; i < commandCount; i++)
{
    string command = Console.ReadLine();

    switch (command)
    {
        case "ammo":
            currentAmmo += ammoValue;
            break;
        case "save":
            lastSavedAmmo = currentAmmo;
            break;
        case "load":
            currentAmmo = lastSavedAmmo;
            break;
        case "shoot":
            currentAmmo--;
            break;
    }
    Console.WriteLine(currentAmmo);
}

