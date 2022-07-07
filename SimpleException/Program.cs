using SimpleException;
Console.WriteLine("****** Simple Exception Example *****\n");
Console.WriteLine($"=> Creating a car and stepping on it!");

Car myCar = new Car("Zippy",45);
myCar.CrankTunes(true);
 for (int i = 0; i < 10; i++)
    myCar.Accelerate(10);

Console.ReadLine();