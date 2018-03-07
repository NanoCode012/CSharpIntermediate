using System;

namespace CSharpIntermediate_Interfaces
{
    public class Order
    {
        public float TotalCost { get; set; }
        public Shipment Shipment { get; set; }
        public DateTime DatePlaced { get; set; }
        public bool IsShipped
        {
            get
            {
                return (Shipment != null);
            }
        }
    }
}
