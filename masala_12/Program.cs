System.Console.Write("Haroratni kiriting: ");
double celsius = Convert.ToDouble(Console.ReadLine());

double farangeyt = celsius * 9.0 / 5 + 32;

double kelvin = celsius + 273.15;

System.Console.WriteLine($"Selsiy: {celsius}");
System.Console.WriteLine($"Farangeyt: {farangeyt:N2}");
System.Console.WriteLine($"Kelvin: {kelvin:N2}");
System.Console.WriteLine($"Noldan past: {celsius < 0}");