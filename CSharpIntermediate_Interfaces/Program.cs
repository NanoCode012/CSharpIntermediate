using System;

namespace CSharpIntermediate_Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order()
            {
                TotalCost = 10f,
                DatePlaced = DateTime.Now
            };
            orderProcessor.Process(order);
        }
    }
}
