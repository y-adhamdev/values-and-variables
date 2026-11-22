using System;

namespace MyApplication
{
    class Program
    {
        static void Main()
        {
            System.Console.Write("Kurs nomini kiriting: ");
            string? courseName = Console.ReadLine();

            System.Console.Write("Rejalashtirilgan: ");
            double academicHour = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Oraliq masofa: ");
            double span = Convert.ToDouble(Console.ReadLine());

            System.Console.Write("Kurs narxi: ");
            decimal cost = Convert.ToDecimal(Console.ReadLine());

            System.Console.Write("Kurs kodi: ");
            char CourseCode = Convert.ToChar(Console.ReadLine());

            System.Console.Write("Bajarilganlik holati: ");
            bool isDone = Convert.ToBoolean(Console.ReadLine());

            System.Console.Write("Baytlar soni: ");
            long size = Convert.ToInt64(Console.ReadLine());

            System.Console.WriteLine("__________________________________________________________");

            System.Console.WriteLine($"Mavzu: {courseName}");
            System.Console.WriteLine($"Rejalashtirilgan: {academicHour}");
            System.Console.WriteLine($"Masofa: {span}");
            System.Console.WriteLine($"Soatlik haq: {cost}");
            System.Console.WriteLine($"Kod: {CourseCode}");
            System.Console.WriteLine($"Bajarildi: {isDone}");
            System.Console.WriteLine($"Baytlar: {size}");
        }
    }
}