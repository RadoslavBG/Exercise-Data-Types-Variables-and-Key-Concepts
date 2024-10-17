int ammountofNylon = int.Parse(Console.ReadLine());
int ammountofPaint = int.Parse(Console.ReadLine());
int ammountofThinnder = int.Parse(Console.ReadLine());
int hourswork = int.Parse(Console.ReadLine());

double protectiveNylonPerMeter = 1.50;
double paintPricePerLitter = 14.50;
double thinnerPricePerLitter = 5;
double bagsPrice = 0.40;

double priceForNylon = (ammountofNylon + 2) * protectiveNylonPerMeter;
double priceForPaint = ammountofPaint * 1.1 * paintPricePerLitter;
double PriceForThinner = ammountofThinnder * thinnerPricePerLitter;

double priceForMaterials = priceForNylon + priceForPaint + PriceForThinner + bagsPrice;

double priceForOneHourWork = priceForMaterials * 0.3;
double priceForWorkers = priceForOneHourWork * hourswork;

double finalPrice = priceForMaterials + priceForWorkers;

Console.WriteLine(finalPrice);

