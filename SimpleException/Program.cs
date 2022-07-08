using SimpleException;
Console.WriteLine("****** Simple Exception Example *****\n");
Console.WriteLine($"=> Creating a car and stepping on it!");

Car myCar = new Car("Zippy", 45);
myCar.CrankTunes(true);
try
{
    for (int i = 0; i < 10; i++)
        myCar.Accelerate(10);
}
catch (Exception e)
{
    Console.WriteLine("\n**** Error! ****");
    Console.WriteLine($"Member name: {e.TargetSite}");
    Console.WriteLine($"Class defining member: {e.TargetSite.DeclaringType}");
    Console.WriteLine($"Member type: {e.TargetSite.MemberType}");
    Console.WriteLine($"Message: {e.Message}");
    Console.WriteLine($"Source: {e.Source}");
    Console.WriteLine("\n**** Out of exception logic! ****");

}

Console.ReadLine();