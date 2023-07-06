// input : 1갤런 당 갈수 있는 마일 수
// 1GL => 1L : 3.785411784 L
// 1Mile => 1M : 1609.344 M
// 출력 : 100km 당 소비하는 리터

// input : 10.00 mi == 1갤런 당 10 마일 이동;
// mi => km 변환 = 10.00 * 1.60934 = 16.09344 km
// 1km => 1갤런 변환 / 16.09344 = 0.06213711 갤런
// 100km 당 갤런 = 0.06213711 * 100 = 6.213711 갤런
// 갤런 => L 변환 = 6.213711 * 3.785411784 = 23.5214548 L

double mile = double.Parse(Console.ReadLine());
double mileToKm = mile * 1.609344;
double gallonPerKm =  1 / mileToKm;
double km100PerGallo = gallonPerKm * 100;
double gallonToL = km100PerGallo * 3.785411784;

Console.WriteLine($"{gallonToL:0.000000}");