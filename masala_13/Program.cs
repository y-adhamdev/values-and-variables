using System.Reflection.Metadata;

Console.Write("Foydalanuvchi nomini kiriting: ");
string? userName = Console.ReadLine();
System.Console.WriteLine(userName);


string? newStr = (string)userName.Clone();

string newStrWithNoSpace = newStr.Trim();
string newStrWithUnderScore = newStr.Replace(" ", "_");
string newStrInUpperCase = newStr.ToUpperInvariant();
System.Console.WriteLine("==============================================");
System.Console.WriteLine($"Asl uzunlik: {userName.Length}");
System.Console.WriteLine($"Foydalanuvchi nomi: {newStrInUpperCase}");
System.Console.WriteLine($"Foydalanuvchi nomi uzunligi: {newStrWithNoSpace.Length}");
System.Console.WriteLine($"Pastgi chiziq bor: {newStrWithUnderScore.Contains("_")}");
System.Console.WriteLine($"Uzunlik diapazonga mos: {newStrWithUnderScore.Length > 5 && newStrWithUnderScore.Length < 12}");