int coupon = int.Parse(Console.ReadLine());
int price = int.Parse(Console.ReadLine());

int a = 100;
int b = 200;

(a, b) = (b, a);

int coupon5 = Math.Clamp(price - 500, 0, int.MaxValue);
int coupon10 = (int)(price - price * 0.1f);
int coupon15 = Math.Clamp(price - 2000, 0, int.MaxValue);
int coupon20 = (int)(price - price * 0.25f);

if (coupon >= 20)
    Console.WriteLine($"{Math.Min(coupon15, coupon20)}");
else if (coupon >= 15)
    Console.WriteLine($"{Math.Min(coupon10, coupon15)}");
else if (coupon >= 10)
    Console.WriteLine($"{Math.Min(coupon5, coupon10)}");
else if (coupon >= 5)
    Console.WriteLine($"{coupon5}");
else
    Console.WriteLine(price);