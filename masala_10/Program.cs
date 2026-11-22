System.Console.Write("Kurs nomini kiriting: ");
string? courseName = Console.ReadLine();

System.Console.Write("Rejalashtirilgan: ");
int plannedTime = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Oraliq masofa: ");
int spentMinutes = Convert.ToInt32(Console.ReadLine());

System.Console.Write("Kurs narxi: ");
decimal costPerHour = Convert.ToDecimal(Console.ReadLine());

const int MinutesPerHour = 60;

System.Console.WriteLine("=======================================");
System.Console.WriteLine($"Mavzu: {courseName}");
System.Console.WriteLine($"Rejalashtirilgan: {plannedTime} daqiqa");
System.Console.WriteLine($"Amalda sarflangan: {spentMinutes} daqiqa");
System.Console.WriteLine($"Qolgan daqiqalar: {plannedTime - spentMinutes} daqiqa");
System.Console.WriteLine($"Narx: {(costPerHour * spentMinutes)/MinutesPerHour:N2}"); //  $12 / 60 = 0.2 * 25 = $5 ||  $12 * 25 = 300 / 60 = 5
System.Console.WriteLine($"Maqsadga erishilgan: {spentMinutes > plannedTime}");       
System.Console.WriteLine($"Ko'proq vaqt kerak: {plannedTime > 0 & (plannedTime - spentMinutes) > 0}");                                     
                                                                      

