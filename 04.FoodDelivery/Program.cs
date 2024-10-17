int chickenMenuToOrder = int.Parse(Console.ReadLine());
int fishMenuToOrder = int.Parse(Console.ReadLine());
int VeggyMenuToOrder = int.Parse(Console.ReadLine());

double chickenMenu = 10.35;
double fishMenu = 12.40;
double VeggyMenu = 8.15;
double deliveryFee = 2.50;

double totalMenuPrice = (chickenMenu * chickenMenuToOrder) + (fishMenu * fishMenuToOrder) + (VeggyMenu * VeggyMenuToOrder);

double priceForDessert = totalMenuPrice * 0.20;

double OrderPrice = totalMenuPrice + priceForDessert + deliveryFee;

Console.WriteLine(OrderPrice);