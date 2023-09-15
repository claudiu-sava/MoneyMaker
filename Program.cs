namespace MoneyMaker;

class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to Money Maker!");
        Console.WriteLine("How many points do you have?");
        Console.Write(">>> ");

        int goldCoinValue = 10;
        int silverCoinValue = 5;
        int bronzeCoinValue = 1;

        double points = Convert.ToDouble(Console.ReadLine());
        
        Console.WriteLine($"Great! You have {points} points!");

        double goldCoins = Math.Floor(points / goldCoinValue);
        Console.WriteLine($"GoldCoins: {goldCoins}");

        double rest1 = points % (goldCoins * goldCoinValue);
        
        double silverCoins = Math.Floor(rest1 / silverCoinValue);
        Console.WriteLine($"Silver Coins: {silverCoins}");

        double rest2 = rest1 % (silverCoins * silverCoinValue);

        if (Double.IsNaN(rest2))
        {
            rest2 = rest1;
        }

        double bronzeCoins = Math.Floor(rest2 / bronzeCoinValue);

        Console.WriteLine($"Bronze Coins: {bronzeCoins}");
    }
}