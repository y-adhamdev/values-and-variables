1. Savol: Ma'lumot turlaridan foydalanib mashg'ulot kartasini yarating

Berilgan: mavzu C#, rejalashtirilgan daqiqalar 40, masofa 1.5, soatlik narx 12.50, kod B, bajarilganlik holati false va baytlar soni 5000000000.

Vazifa: mos ravishda string, int, double, decimal, char va bool turlaridan foydalaning. Baytlar soni uchun mos butun son turini tanlang. Har bir qiymatni nomi bilan alohida satrda chiqaring. Har bir tur tanlovini tushuntiring va baytlar soni uchun nima sababdan int ishlatib bo'lmasligini darsdagi qiymatlar oralig'i jadvali yordamida izohlang.

Kutilgan natija:

Mavzu: C#
Rejalashtirilgan: 40
Masofa: 1.5
Soatlik haq: 12.50
Kod: B
Bajarildi: False
Baytlar: 5000000000
2. Savol: Qayta qiymat bering, turni avtomatik aniqlang va nusxalang

Berilgan: amalda sarflangan daqiqalar 20, var sessionCount = 3, const int MinutesPerHour = 60 va dastlabki mavzu "C#".

Vazifa: amalda sarflangan daqiqalar qiymatini 25 ga o'zgartiring; shu qiymatni va har biri bir soatlik uchta mashg'ulotning jami daqiqalarini chiqaring. Amalda sarflangan daqiqalar va mavzuni ikkita yangi o'zgaruvchiga nusxalang, so'ng faqat shu nusxalarga mos ravishda 30 va "SQL" qiymatlarini bering.

Kutilgan natija:

Amalda sarflangan: 25
Jami daqiqalar: 180
Daqiqalar asl/nusxa: 25, 30
Mavzu asl/nusxa: C#, SQL
Avtomatik aniqlangan turni, nima uchun konstantani o'zgartirib bo'lmasligini va nusxalarga qayta qiymat berish nega asl o'zgaruvchilarni o'zgartirmasligini tushuntiring. Qaysi biri qiymat turi, qaysi biri havola turi ekanini aniqlang.

3. Savol: Arifmetik ifodalarni hisoblang

Berilgan ifodalar: 18 + 7, 18 - 7, 18 * 7, 18 / 7, 18 % 7, 18.0 / 4, 2 + 3 * 4, (2 + 3) * 4.

Vazifa: natijalarni oldindan taxmin qiling va berilgan tartibda chiqaring. Bo'lish, qoldiqni topish va qavslar bilan guruhlashni tushuntiring.

Kutilgan qiymatlar: 25, 11, 126, 2, 4, 4.5, 14, 20.

4. Savol: Har bir qiymatni yangilash operatorini qo'llang

Berilgan: int practiceMinutes = 12.

Vazifa: boshlang'ich qiymatni chiqaring; += 8, -= 2, *= 3, /= 4, ++ va -- amallarini shu tartibda qo'llang va har bir yangilashdan keyin qiymatni chiqaring. Har bir amalning unga teng kuchli uzun qiymat berish shaklini README faylingizga yozing.

Kutilgan qiymatlar: 12, 20, 18, 54, 13, 14, 13. Bo'lish orqali yangilashda nima uchun 13.5 emas, 13 saqlanishini tushuntiring.

5. Savol: Son turlarini o'zgartirish usullarini solishtiring

Berilgan: butun son 30, double turidagi 9.7 va 7, 2 operandlari.

Vazifa: butun sonni yashirin tarzda double turiga o'tkazing; 9.7 ni ochiq tur o'zgartirish orqali int ga o'tkazing; Convert.ToInt32(9.7) ni chaqiring; (double)7 / 2 va (double)(7 / 2) ni hisoblang.

Kutilgan qiymatlar: 30, 9, 10, 3.5, 3. Operand turini o'zgartirish va natija turini o'zgartirish o'rtasidagi farqni tushuntiring.

6. Savol: Matnni songa aylantiring va xatoni aniqlang

Berilgan matnlar: "48", "3.75", "9.90".

Vazifa: "48" ni ham Convert.ToInt32(), ham int.Parse() yordamida songa aylantiring. Qolgan ikkita satrni double.Parse() va decimal.Parse() yordamida mos son turlariga aylantiring.

Kutilgan qiymatlar: 48, 48, 3.75, 9.90.

Dasturni alohida ishga tushirishda int.Parse() ga berilgan butun son matnini vaqtincha "hello" bilan almashtiring. Kutilgan xato: qayta ishlanmagan FormatException; bajarilish shu aylantirishdan keyin davom etmaydi. Istisno turini yozib oling va sababini tushuntiring. Muhitga qarab farq qilishi mumkin bo'lgan diagnostika xabarining aynan bir xil matniga tayanmang. Topshiradigan dasturingiz muvaffaqiyatli ishlashi uchun keyin yaroqli ma'lumotni tiklang. Istisnodan keyin dasturni tiklab davom ettirish kodi talab qilinmaydi.

7. Savol: Satrlarni tekshiring va o'zgartiring

Berilgan: string rawTopic = "  Learn C#  ";.

Vazifa: mavzu boshidagi va oxiridagi bo'shliqlarni olib tashlang, so'ng uning asl uzunligini, tozalangan matnni, tozalangan matn uzunligini, katta harflardagi matnni, unda "C#" bor-yo'qligini va "C#" o'rniga ".NET" qo'yilgan variantini chiqaring. Nomlangan satrni bir marta satrlarni birlashtirish, bir marta esa interpolyatsiya yordamida chiqaring. Shuningdek, string.IsNullOrWhiteSpace() yordamida "   " faqat bo'shliqlardan iborat ekanini tekshiring.

Kutilgan natija:

Asl uzunligi: 12
Tozalangan mavzu: Learn C#
Tozalangan uzunligi: 8
Katta harflarda: LEARN C#
C# bor: True
Almashtirilgan matn: Learn .NET
Mavzu: Learn C#
Mavzu: Learn C#
Bo‘sh kiritish: True
Satrlar o'zgarmas ekanini, Contains() katta-kichik harflarni farqlashini va bu amallar rawTopic ni o'zgartirmasdan qiymat qaytarishi yoki hisoblashi haqida tushuntiring.

8. Savol: Konsoldan matn o'qing va kiritilgan sonlar bilan hisoblang

Konsolga har biri alohida satrda kiritiladi: ism  Alex , mavzu  C# , masofa 7.5, soatlardagi davomiylik 2.5.

Vazifa: ism va mavzuni matn sifatida saqlang, ularning boshidagi va oxiridagi bo'shliqlarni olib tashlang. Darsdagi kiritilgan ma'lumot yaroqli deb hisoblash qoidasiga amal qilib, masofa va davomiylikni double.Parse() bilan songa aylantiring. Interpolyatsiya yordamida salomlashuvni chiqaring va masofani davomiylikka bo'lib tezlikni hisoblang. Tezlikni kasr qismida ikki xona bilan formatlab chiqaring.

Kutilgan natija:

Salom, Alex! Bugungi mavzu: C#.
O‘rtacha tezlik: 3.00 km/h
Matnni nima uchun songa aylantirish kerakligini va darsda ishlatilgan ! belgisi nima uchun kiritilgan ma'lumotning yaroqliligini tekshirmasligini tushuntiring. null kiritish natijasi va bo'sh satr o'rtasidagi farqni izohlang. Ekran tasvirlarida shaxsiy ma'lumotlar emas, namunaviy ismlardan foydalaning.

9. Savol: Taqqoslashlar va rostlik jadvallarini chiqaring

Berilgan: amalda sarflangan daqiqalar 30, rejalashtirilgan daqiqalar 40.

Vazifa: ==, !=, >, <, >= va <= taqqoslashlarini shu tartibda chiqaring.

Kutilgan qiymatlar: False, True, False, True, False, True.

Keyin ikkita mantiqiy qiymatning barcha to'rtta kombinatsiyasini alohida yozib chiqaring. Har bir satr uchun bitta chiqarish buyrug'idan foydalaning va ikkala mantiqiy natijani ham hisoblang; natija matnini tayyor holda kodga yozmang.

Kutilgan jadval:

A B VA YOKI
False False False False
False True False True
True False False True
True True True True
So'ng !false va !true ni chiqaring: True va False kutiladi. = va == o'rtasidagi farqni hamda rostlik jadvalidagi bitta satrni tushuntiring.

10. Savol: Interaktiv o'quv mashg'uloti kalkulyatorini yarating

Konsolga har biri alohida satrda kiritiladi: mavzu C#, rejalashtirilgan daqiqalar 40, amalda sarflangan daqiqalar 25, soatlik narx 12.50.

Vazifa: mavzuni matn sifatida o'qing, davomiyliklarni int ga, soatlik narxni esa decimal ga aylantiring. Bir soatdagi daqiqalar soni uchun yaratgan konstantangizdan qayta foydalaning. Quyidagilarni hisoblang va chiqaring:

Qolgan daqiqalar: rejalashtirilgan va amalda sarflangan daqiqalar ayirmasi.
Xarajat: soatlik narxni amalda sarflangan daqiqalarga ko'paytirib, bir soatdagi daqiqalar soniga bo'lish.
Maqsadga erishilgan: amalda sarflangan daqiqalar rejalashtirilgandan kam emas.
Reja doirasida: amalda sarflangan daqiqalar rejalashtirilgandan ko'p emas.
Ko'proq vaqt kerak: maqsadga erishilmagan VA qolgan daqiqalar musbat.
Kutilgan yakuniy natija:

Mavzu: C#
Rejalashtirilgan: 40 daqiqa
Amalda sarflangan: 25 daqiqa
Qolgan: 15 daqiqa
Narx: 5.21
Maqsadga erishildi: False
Rejaga mos: True
Ko‘proq vaqt kerak: True
Xarajat kasr qismida ikki xona bilan formatlab ko'rsatiladi. Formatlash asl qiymatni o'zgartirmaydi. Mavzu, rejalashtirilgan vaqt va narxni o'zgartirmagan holda, quyidagi amalda sarflangan vaqtlarning har birini kiritib, dasturni uch marta alohida ishga tushiring. Ishga tushirishlarni avtomatlashtirmang.

Amalda sarflangan daqiqalar	Qolgan daqiqalar	Ko'rsatilgan xarajat	Maqsadga erishilgan	Reja doirasida	Ko'proq vaqt kerak
25	15	5.21	False	True	True
40	0	8.33	True	True	False
50	-10	10.42	True	False	False
Oxirgi holatdagi manfiy ayirmani saqlang. Mantiqiy qiymatlarni to'g'ridan-to'g'ri chiqaring.

11. Savol: Sekundlarni soat, daqiqa va sekundga ajrating

Konsolga kiritiladi: jami sekundlar 7384.

Vazifa: kiritilgan matnni int ga aylantiring. Butun sonli bo'lish va % yordamida to'liq soatlar, ortib qolgan to'liq daqiqalar va qolgan sekundlarni hisoblang. Bir daqiqadagi sekundlar va bir soatdagi daqiqalar sonini konstantalarda saqlang. Natijalarni interpolyatsiya yordamida chiqaring.

Kutilgan natija:

Soat: 2
Daqiqa: 3
Soniya: 4
Qayta hisoblangan soniyalar: 7384
Hisoblangan uchta qismdan jami sekundlarni qayta hisoblang va oxirgi satrda chiqaring. Nima uchun butun sonli bo'lish va qoldiq bu masalaga mos kelishini tushuntiring. Dasturni alohida ishga tushirib, 59 va 3600 ni ham tekshiring: mos ravishda 0 soat, 0 daqiqa, 59 sekund va 1 soat, 0 daqiqa, 0 sekund chiqishi kerak. Faqat manfiy bo'lmagan butun sonlar kiriting.

12. Savol: Haroratni boshqa birliklarga o'tkazing

Konsolga kiritiladi: Selsiy bo'yicha harorat 25.

Vazifa: haroratni double sifatida o'qing. Farengeyt qiymatini celsius * 9.0 / 5 + 32, Kelvin qiymatini esa celsius + 273.15 formulasi bilan hisoblang. Har uchala haroratni kasr qismida ikki xona bilan chiqaring. Selsiy harorati 0 dan kichik ekanini ham mantiqiy qiymat sifatida chiqaring.

Kutilgan natija:

Selsiy: 25.00
Farengeyt: 77.00
Kelvin: 298.15
Noldan past: False
Formulada celsius * (9 / 5) ishlatilsa nima o'zgarishini tushuntiring. Dasturni -10 bilan ham alohida ishga tushiring: Farengeyt 14.00, Kelvin 263.15, oxirgi natija esa True bo'lishi kerak.

13. Savol: Foydalanuvchi nomini tozalang va tekshiring

Konsolga kiritiladi: foydalanuvchi nomi  Ali Vali .

Vazifa: asl matnni alohida saqlang. Trim() bilan chetdagi bo'shliqlarni olib tashlang, Replace() bilan ichki bo'shliqlarni _ ga almashtiring va ToUpperInvariant() bilan katta harflarga o'tkazing. Hosil bo'lgan nomning uzunligini, unda _ borligini va uzunligi 5 dan 12 gacha ekanini tekshiring. Ikkala chegara ham oraliqqa kiradi. Tekshiruv natijalarini xabar tanlamasdan, mantiqiy qiymat sifatida chiqaring.

Kutilgan natija:

Asl uzunligi: 12
Foydalanuvchi nomi: ALI_VALI
Foydalanuvchi nomi uzunligi: 8
Pastki chiziq bor: True
Uzunlik diapazonga mos: True
Asl matn nega o'zgarmaganini va oraliqni tekshirish uchun nima sababdan && kerakligini tushuntiring. 4, 5, 12 va 13 belgili nomlar bilan alohida ishga tushirishlarda chegara qiymatlarini tekshiring.

14. Savol: Kutubxonadan kitob olish talablarini tekshiring

Konsolga har biri alohida satrda kiritiladi: yosh 16, kutubxona kartasi borligi "true", kechiktirilgan kitob borligi "false".

Vazifa: yoshni int.Parse() yordamida o'qing. Qolgan ikkita javob uchun faqat "true" yoki "false" kiritiladi; har bir o'qilgan satrni "true" bilan == orqali solishtirib, bool qiymat hosil qiling. Quyidagilarni hisoblang:

Yosh talabi: yosh kamida 14.
Kitob olish mumkin: yosh talabi bajarilgan, karta bor VA kechiktirilgan kitob yo'q.
Yordam kerak: karta yo'q YOKI kechiktirilgan kitob bor.
Kutilgan natija:

Yosh talabi bajarildi: True
Qarzga olish mumkin: True
Yordam kerak: False
&&, || va ! operatorlarining har biri qaysi talabni ifodalashini tushuntiring. Quyidagi holatlarni alohida ishga tushirishlarda tekshiring; natijalarni tayyor matn sifatida kodga yozmang.

Yosh	Karta bor	Kechiktirilgan kitob bor	Yosh talabi bajarilgan	Kitob olish mumkin	Yordam kerak
13	true	false	False	False	False
14	true	false	True	True	False
16	false	true	True	False	True
15. Savol: Xarid cheki va budjet hisobotini yarating

Bu mashqda satrlar, konsoldan kiritish, tur o'zgartirish, arifmetika va mantiqiy ifodalarni bitta ketma-ket dasturda birlashtiring.

Konsolga har biri alohida satrda kiritiladi: xaridor "  Aziza  ", birinchi mahsulot "  Daftar  ", uning soni 3, dona narxi 12.50, ikkinchi mahsulot "  Ruchka  ", uning soni 2, dona narxi 7.25, chegirma foizi 10, yetkazib berish narxi 5.00, budjet 50.00. Qo'shtirnoqlarni kiritmang; ular matn chetidagi bo'shliqlarni ko'rsatadi.

Vazifa: ismlar va mahsulot nomlarini tozalang. Mahsulot sonlarini int, narxlar, chegirma foizi va budjetni decimal sifatida o'qing. Har bir mahsulot uchun alohida o'zgaruvchilar ishlating; kolleksiyalar kerak emas. Quyidagilarni hisoblang:

Har bir mahsulot summasi: soni ko'paytirilgan dona narxi.
Oraliq jami: ikkala mahsulot summalarining yig'indisi.
Chegirma summasi: oraliq jami ko'paytirilgan chegirma foizi, 100 ga bo'lingan.
To'lov: oraliq jamidan chegirmani ayirib, yetkazib berish narxini qo'shish.
Qolgan budjet: budjetdan to'lovni ayirish.
Jami mahsulot soni: ikkala mahsulot sonining yig'indisi.
Budjet yetarli: budjet to'lovdan kam emas.
Xarid talablarga mos: ikkala mahsulot soni ham musbat VA chegirma foizi 0 dan 100 gacha, chegaralar bilan birga.
Xaridni tasdiqlash mumkin: xarid talablarga mos VA budjet yetarli.
Kutilgan natija:

Mijoz: Aziza
Daftar: 3 x 12.50 = 37.50
Ruchka: 2 x 7.25 = 14.50
Jami mahsulotlar: 5
Oraliq jami: 52.00
Chegirma: 5.20
Yetkazib berish: 5.00
Jami: 51.80
Qolgan byudjet: -1.80
Byudjet yetarli: False
Xarid yaroqli: True
Tasdiqlash mumkin: False