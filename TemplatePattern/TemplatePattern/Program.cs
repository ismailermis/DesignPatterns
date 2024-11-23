// See https://aka.ms/new-console-template for more information

// Burger(true);
using TemplatePattern;

public class Program
{
    public static void Main(string[] args)
    {
        Burger(false);
        // Wait for user
        Console.ReadKey();
    }

    public static MakeBurger Burger(bool isVegBurger)
    {
        if (isVegBurger)
        {
            MakeBigKingBurger burger = new();
            burger.Prepare();
            return burger;
        }
        else
        {
            MakeChickenBurger burger = new();
            burger.Prepare();
            return burger;
        }
    }
}
