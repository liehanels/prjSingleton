using prjSingleton;
using System.Threading.Channels;

Console.WriteLine("Welcome to the Singleton-console app that does nothing productive.");
Console.WriteLine("Please press <Enter> to continue.\n");
var key = Console.ReadKey();
    DbUtil one = DbUtil.getInstance();
    DbUtil two = DbUtil.getInstance();
    DbUtil three = DbUtil.getInstance();

Console.WriteLine("Lunch Time !!");
Lunch myOrder = Lunch.getInstance();
myOrder.setLunchOrder("Ham and cheese on bread");
Lunch myOrder2 = Lunch.getInstance();
myOrder2.setLunchOrder("Mayo on egg");
Lunch myOrder3 = Lunch.getInstance();
Console.WriteLine(myOrder3.getLunchOrder());