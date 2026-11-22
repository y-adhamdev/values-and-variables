System.Console.Write("Ismingizni kiriting: ");
string? name = Console.ReadLine();

System.Console.Write("Mavzu: ");
string? theme = Console.ReadLine();

System.Console.Write("Masofani kiriting: ");
double span = Convert.ToDouble(Console.ReadLine());

System.Console.Write("Davomiylik: ");
double duration = Convert.ToDouble(Console.ReadLine());

string NameAndTheme = $"     Salom, {name}! Bugungi mavzu: {theme}. ";
// System.Console.WriteLine(NameAndTheme);
System.Console.WriteLine(NameAndTheme.Trim());
System.Console.WriteLine($"O'rtacha tezlik {span/duration:N2} km/h");