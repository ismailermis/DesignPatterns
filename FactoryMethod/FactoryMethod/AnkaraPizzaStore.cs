namespace FactoryMethod;

class AnkaraPizzaStore : PizzaStore
{
    protected override IPizza CreatePizza(string type)
    {
        return type switch{
            "cheese" => new CheesePizza(),
            "veggi" => new VeggiPizza(),
            _=> throw new ArgumentException("invalid pizza type", nameof(type)),
        };
    }
}
