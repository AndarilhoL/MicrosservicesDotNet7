namespace DevTrackR.ShippingOrders.Core.Entities
{
    public class ShippingOrderService
    {
        public ShippingOrderService(string title, decimal price)
        {
            Title = title;
            Price = price;
        }

        public string Title { get; private set; }
        public decimal Price { get; private set; }
    }
}