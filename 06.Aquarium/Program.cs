int length = int.Parse(Console.ReadLine());
int width = int.Parse(Console.ReadLine());
int height = int.Parse(Console.ReadLine());
double percentage = double.Parse(Console.ReadLine());

double volumeInCm3 = length * width * height;

double volumeInLiters = volumeInCm3 / 1000;

double occupiedVolume = volumeInLiters * (percentage / 100);

double litersOfWater = volumeInLiters - occupiedVolume;

Console.WriteLine($"{litersOfWater:F2}");
