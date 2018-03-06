using NUnit.Framework;
using System;
using CSharpIntermediate_Interfaces;

namespace CSharpIntermediate_Interfaces_UnitTests
{
    //Name of class follow convention : (CLASSNAME)TESTS
    [TestFixture()]
    public class OrderProcessorTests
    {
        //Name of method follow convention : (METHODNAME)_CONDITION_EXPECTATIONS
        [Test()]
        [ExpectedException(typeof(InvalidOperationException))]
        public void Process_OrderIsShipped_ThrowsException()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order { Shipment = new Shipment() };
            orderProcessor.Process(order);
        }

        [Test()]
        public void Process_OrderIsNotShipped_ShouldSetShipmentPropertyOfOrder()
        {
            var orderProcessor = new OrderProcessor(new FakeShippingCalculator());
            var order = new Order();
            orderProcessor.Process(order);
            Assert.IsTrue(order.IsShipped);
            Assert.IsNotNull(order.Shipment);
            Assert.AreEqual(1, order.Shipment.Cost);
            Assert.AreEqual(DateTime.Today.AddDays(1), order.Shipment.ShippingDate);
        }
    }

    public class FakeShippingCalculator : IShippingCalculator
    {
        public float CalculateShipping(Order order)
        {
            return 1f;
        }
    }
}
