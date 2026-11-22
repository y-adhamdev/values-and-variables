using System.ComponentModel;

string customer = "Aziza";
string firstItem = "  Daftar   ";
int firstItemCount = 3;
decimal firstItemCosts = 12.50m;

string secondItem = "  Ruchka   ";
int secondItemCount = 2;
decimal SecondItemCosts = 7.25m;

decimal discount = 10;
decimal deliveryCost = 5.00m;
decimal budget = 80.00m;

decimal firstPurchase = firstItemCount * firstItemCosts;
decimal secondPurchase = secondItemCount * SecondItemCosts;
decimal overallCostOfItems = firstPurchase + secondPurchase;
decimal overallSpent = overallCostOfItems - (overallCostOfItems/discount) + deliveryCost;
bool isValid = (firstItemCount > 0 && secondItemCount > 0 && discount >= 0 && discount <= 100);


System.Console.WriteLine($"Mijoz: {customer.Trim()}");
System.Console.WriteLine($"{firstItem.Trim()}: {firstItemCount} x {firstItemCosts} = {firstPurchase:N2}");
System.Console.WriteLine($"{secondItem.Trim()}: {secondItemCount} x {SecondItemCosts} = {secondPurchase:N2}");
System.Console.WriteLine($"Jami mahsulotlar soni: {firstItemCount + secondItemCount}");
System.Console.WriteLine($"Oraliq jami: {overallCostOfItems}");
System.Console.WriteLine($"Chegirma: {overallCostOfItems/discount}");
System.Console.WriteLine($"Yetkazib berish: {deliveryCost}");
System.Console.WriteLine($"Jami: {overallSpent}");
System.Console.WriteLine($"Qolgan budget: { budget - overallSpent}");
System.Console.WriteLine($"Byudjet yetarlimi: {budget >= overallSpent}");
System.Console.WriteLine($"Xarid yaroqli: {isValid}");
System.Console.WriteLine($"Tasdiqlash mumkin: {isValid == true && (budget >= overallSpent) == true}");

