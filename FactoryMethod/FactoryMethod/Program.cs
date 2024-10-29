using FactoryMethod;

PizzaStore pizzaStoreAnkara= new AnkaraPizzaStore();
PizzaStore pizzaStoreIstanbul= new IstanbulPizzaStore();

IPizza cheesePizza = pizzaStoreAnkara.OrderPizza("cheese");
Console.WriteLine("Cheese pizza ordered in ankara stora");

IPizza veggiPizza = pizzaStoreIstanbul.OrderPizza("veggi");

Console.WriteLine("Veggi pizza ordered in istanbul stora");
