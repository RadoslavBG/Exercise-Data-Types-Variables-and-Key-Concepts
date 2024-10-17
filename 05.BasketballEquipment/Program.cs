int annualFee = int.Parse(Console.ReadLine());

double sneakersPrice = annualFee - (annualFee * 0.40);
double uniform = sneakersPrice - (sneakersPrice * 0.20);
double ball = uniform / 4;
double accessories = ball / 5;

double priceToTrain = annualFee + sneakersPrice + uniform + ball + accessories;

Console.WriteLine(priceToTrain);