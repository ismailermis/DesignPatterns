// See https://aka.ms/new-console-template for more information
using Builder;

Console.WriteLine("Hello, World!");

var order = OrderBuilder.Empty()
.WithNumber(10)
.CreatedOn(DateTime.UtcNow)
.ShippedTo(b => b
    .Street("street")
    .City("City")
    .Country("Country")
    .Zip("Zip")
    )
.Build();

List<Order[]> orders = Enumerable
.Range(1, 10)
.Select(number => OrderBuilder.Empty()
        .CreatedOn(DateTime.UtcNow)
        .WithNumber(number)
        .ShippedTo(b => b
            .City("city")
            .Country("country")
            .Street("street")
            .Zip("zip"))
        .Build()
).Chunk(4).ToList();

Console.WriteLine(order.CreatedOn.ToString());