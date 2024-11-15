// See https://aka.ms/new-console-template for more information

/*
    yeni sipariş
    işleniyor
    yolda/gönderimde
    Teslim edildi
*/

var order = new Order();
order.PrintOrderState();
order.NextState();
//--
order.NextState();
order.PrintOrderState();
//--
order.NextState();
order.PrintOrderState();

Console.ReadLine();
record DeliveredState : IOrderState
{
    public void Next(Order order)
    {
        Console.WriteLine("This is the final state");
    }

    public void Previous(Order order)
    {
        order.State = new OnTheWayState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("This is Delivered");
    }
}
//-----------------------------
record OnTheWayState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new DeliveredState();
    }

    public void Previous(Order order)
    {
        order.State = new ProcessingState();
    }

    public void PrintStatus()
    {
         Console.WriteLine("Order is on the way");
    }
}
//---------------------
record ProcessingState : IOrderState
{
    public void Next(Order order)
    {
        order.State = new OnTheWayState();
    }

    public void Previous(Order order)
    {
        order.State = new NewOrderState();
    }

    public void PrintStatus()
    {
        Console.WriteLine("Order is being processed");
    }
}
//------------
record NewOrderState : IOrderState
{
    public void Next(Order order)
    {
       
        order.State = new ProcessingState();
    }

    public void Previous(Order order)
    {
         Console.WriteLine("This is the initial state");
    }

    public void PrintStatus()
    {
        Console.WriteLine("This is placed");
    }
}
//------------
public interface IOrderState{
    void Next(Order order);
    void Previous(Order order);
    void PrintStatus();
}
 
public class Order
{
    public IOrderState State { get; set; }
    public Order()
    {
        State = new NewOrderState();
    }
    public void NextState(){
        State.Next(this);
    }
    public void PreviousState(){
        State.Previous(this);
    }
    public void PrintOrderState(){
        State.PrintStatus();
    }
}
  