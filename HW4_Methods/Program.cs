/*using System;

class Program
{
    static decimal SilverToUSD(decimal ounces)
    {
        return ounces * 57.75m;
    }
    static void Main()
    {
        decimal silverOunces = 0.0m;
        //prompt user input
        Console.WriteLine("Please enter the number of platinum ounces");
        silverOunces = Convert.ToDecimal(Console.ReadLine());

        decimal totalUSD = 0.0m;
        totalUSD = SilverToUSD(silverOunces);
        Console.WriteLine($"Silver value in USD today: {totalUSD:C2}");
    }
}*/

using System;

class Program
{
    static decimal PlatinumToUSD(decimal ounces)
    {
        return ounces * 1634.00m;
    }
    static void Main()
    {
        decimal platinumOunces = 0.0m;
        //prompt user input
        Console.WriteLine("Please enter the number of platinum ounces");
        platinumOunces = Convert.ToDecimal(Console.ReadLine());

        decimal totalUSD = 0.0m;
        totalUSD = PlatinumToUSD(platinumOunces);
        Console.WriteLine($"Platinum value in USD today: {totalUSD:C2}");
    }
}