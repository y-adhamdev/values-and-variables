System.Console.Write("Sekund kiriting: ");
int sekund = Convert.ToInt32(Console.ReadLine());

int hours = sekund / 3600;
int Minutes = (sekund % 3600)/60;
int soniya = (sekund % 3600)%60;

System.Console.WriteLine($"Soat: {hours}\nDaqiqa: {Minutes}\nSoniya: {soniya}");
System.Console.WriteLine($"Qayta hisoblangan sekundlar: {(hours * 3600) + (Minutes * 60) + soniya}");