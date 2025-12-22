using System;

namespace EventsDemo
{
    public class OrderPlacedEventArgs : EventArgs
    {
        public string OrderId { get; set; }
    }

    public class OrderService
    {
        public event EventHandler<OrderPlacedEventArgs> OrderPlaced;

        public void PlaceOrder(string orderId)
        {
            Console.WriteLine("Order placed.");
            OnOrderPlaced(orderId);
        }

        protected virtual void OnOrderPlaced(string orderId)
        {
            OrderPlaced?.Invoke(this, new OrderPlacedEventArgs { OrderId = orderId });
        }
    }

    class Program
    {
        static void Main()
        {
            OrderService service = new OrderService();
            service.OrderPlaced += EmailService;
            service.PlaceOrder("ORD123");
        }

        static void EmailService(object sender, OrderPlacedEventArgs e)
        {
            Console.WriteLine($"Email sent for Order {e.OrderId}");
        }
    }
}