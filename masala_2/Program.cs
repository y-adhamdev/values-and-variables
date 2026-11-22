using System;

namespace MyApplication
{
    class Programm
    {
        static void Main()
        {
            int spentMinutes = 20;
            var sessionCount = 3;
            const int MinutesPerHour = 60;
            string theme = "C#";

            spentMinutes = 25;

            System.Console.WriteLine($"Amalda sarflangan: {spentMinutes}");
            System.Console.WriteLine($"Jami daqiqalar: {MinutesPerHour * sessionCount}");

            int newSpentMinutes = spentMinutes + 5;
            System.Console.WriteLine($"Daqiqalar als/nusxa: {spentMinutes}/{newSpentMinutes}");

            string newTheme = "SQL";
            System.Console.WriteLine($"Mavzu asl/nusxa: {theme}/{newTheme}");
        /*
        
        Avtomatik aniqlangan turni, nima uchun konstantani o'zgartirib bo'lmasligini va nusxalarga qayta qiymat berish nega asl o'zgaruvchilarni 
        o'zgartirmasligini tushuntiring. Qaysi biri qiymat turi, qaysi biri havola turi ekanini aniqlang.

            constanta maxsus kalit so'z bilan e'lon qilinganligi uchun uni o'zgartirish imkoni yuq.
            o'zgaruvchidan nusxa olinganda faqat undagi qiymatni yangi o'zgaruvchiga yuklayapmiz, ya'ni yangi o'zgaruvchining xotiradagi manziliga yozib qo'yayapmiz.
            shuning uchun eski o'zgaruchining qiymati o'zgarmaydi.
            Qiymat turi ya'ni value type bu o'zida ma'lum bir qiymatni saqlaydi. Undagi ma'lumot stakeda turadi. Reference typeda esa heap xotiradagi qiymatning 
            manzilini saqlanadi.
        */
        }
    }
}