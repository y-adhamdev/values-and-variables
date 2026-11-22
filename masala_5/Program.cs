using System;

namespace MyApplication
{
    class Programm
    {
        static void Main()
        {
            int num = 30;
            double speed = 9.5;
            
            double number = num;
            
            System.Console.WriteLine(number);

            int newNum = (int)speed;// O'ziga yaqin justga qarab yaxlitlaydi.
            System.Console.WriteLine(newNum); 

            int newNumber = Convert.ToInt32(speed); // qaysi butunga yaqin bo'lsa usha tomonga yaxlitlaydi, teng bo'lsa juftga qarab yaxlitlaydi.
            System.Console.WriteLine(newNumber); 

            System.Console.WriteLine((double)7/2); // 3.5
            System.Console.WriteLine((double)(7 / 2)); // 3

            
        }
    }
}