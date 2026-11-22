System.Console.Write("Yoshingizni kiriting: ");
string? input = Console.ReadLine();

System.Console.Write("Kutubxona kartangiz mavjud: ");
bool isThere = Convert.ToBoolean(Console.ReadLine());

System.Console.Write("Kechiktirilgan kitob bor: ");
bool IsLate = Convert.ToBoolean(Console.ReadLine());

int age = int.Parse(input);


bool isValid = (age >= 14 && isThere == true && IsLate == false);
bool needHelp = (isThere == false || IsLate == true);
System.Console.WriteLine("=============================================");
System.Console.WriteLine($"Yosh talabi bajarilgan: {age >= 14}");
System.Console.WriteLine($"Kitob olish mumkin: {isValid}");
System.Console.WriteLine($"Kitob olish mumkin: {needHelp}");

