int highBurger = int.Parse(Console.ReadLine());
int middleBurger = int.Parse(Console.ReadLine());
int lowBurger = int.Parse(Console.ReadLine());
int colaPrice = int.Parse(Console.ReadLine());
int spritePrice = int.Parse(Console.ReadLine());

int minBurgerPrice = Math.Min(highBurger, Math.Min(middleBurger,lowBurger));
int minDrinkPrice = Math.Min(colaPrice, spritePrice);

Console.WriteLine(minBurgerPrice + minDrinkPrice - 50);