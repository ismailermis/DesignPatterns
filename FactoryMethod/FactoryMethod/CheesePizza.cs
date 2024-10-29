using System.Security.Cryptography;

namespace FactoryMethod;

public class CheesePizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Cheese pizza Bake");
    }

    public void Cut()
    {
        Console.WriteLine("Cheese pizza Cut");

    }

    public void Prepare()
    {
        Console.WriteLine("Cheese pizza prepared");

    }
}
