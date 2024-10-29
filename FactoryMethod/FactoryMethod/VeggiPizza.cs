namespace FactoryMethod;

public class VeggiPizza : IPizza
{
    public void Bake()
    {
        Console.WriteLine("Veggi pizza Bake");
    }

    public void Cut()
    {
        Console.WriteLine("Veggi pizza Cut");

    }

    public void Prepare()
    {
        Console.WriteLine("Veggi pizza prepared");

    }
}