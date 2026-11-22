int spendingMinutes = 30;
int plannedTime = 40;

System.Console.WriteLine(spendingMinutes == plannedTime);
System.Console.WriteLine(spendingMinutes != plannedTime);
System.Console.WriteLine(spendingMinutes > plannedTime);
System.Console.WriteLine(spendingMinutes < plannedTime);
System.Console.WriteLine(spendingMinutes >= plannedTime);
System.Console.WriteLine(spendingMinutes <= plannedTime);


System.Console.WriteLine($"{false} && {false} && {false} || {true} = {false && false && false || true}");
System.Console.WriteLine($"{true} && {true} = {true && true}");
System.Console.WriteLine($"{false} && {true} = {false && true}");
System.Console.WriteLine($"{false} && {false} = {true && false}");

System.Console.WriteLine(!true);
System.Console.WriteLine(!false);