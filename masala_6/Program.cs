using System;

namespace MyApplication
{
    class Programm
    {
        static void Main()
        {
            string satr = "48";
            string satr1 = "3.75";
            string satr2 = "9.90";

            int num = Convert.ToInt32(satr);
            int num2 = int.Parse(satr);

            double DoubleNum = double.Parse(satr1);
            decimal decimalNum = decimal.Parse(satr2);

            System.Console.WriteLine(num);
            System.Console.WriteLine(num2);
            System.Console.WriteLine(DoubleNum);
            System.Console.WriteLine(decimalNum);
        }
    }
}