using System;

namespace MyApplication
{
    class Programm
    {
        static void Main()
        {
            int practiceMinutes = 12;
            practiceMinutes += 8;
            System.Console.WriteLine(practiceMinutes); // 20

            practiceMinutes -= 2;
            System.Console.WriteLine(practiceMinutes); // 18

            practiceMinutes *= 3;
            System.Console.WriteLine(practiceMinutes); // 54

            practiceMinutes /= 4;
            System.Console.WriteLine(practiceMinutes); // 13

            practiceMinutes++;
            System.Console.WriteLine(practiceMinutes); // 14

            practiceMinutes--;
            System.Console.WriteLine(practiceMinutes); // 13

            // System.Console.WriteLine((double)18/4);

        }
    }
}