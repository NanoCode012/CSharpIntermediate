namespace CSharpIntermediate_Interfaces
{
    public class ShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            if (order.TotalCost < 30f) return order.TotalCost * 0.1f;
            else return 0f;
        }
    }
}
