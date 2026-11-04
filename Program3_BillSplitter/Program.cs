int totalBill = 250;
int friends = 4;

int wholeShare = totalBill / friends;
int leftover = totalBill % friends;
double exactShare = (double)totalBill / friends;

Console.WriteLine($"Total Bill: PHP {totalBill}");
Console.WriteLine($"Number of friends: {friends}");
Console.WriteLine($"Each pays(integerdivision): PHP {wholeShare}");
Console.WriteLine($"Leftover pesos: PHP {leftover}");
Console.WriteLine($"Each pays (exact): PHP {exactShare:F2}");
