using System;

namespace CSharpIntermediate_Interfaces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Interface for unit testing
            var orderProcessor = new OrderProcessor(new ShippingCalculator());
            var order = new Order()
            {
                TotalCost = 10f,
                DatePlaced = DateTime.Now
            };
            orderProcessor.Process(order);

            //Interface for extensibility. 
            //It is called dependancy injection where old classes are not changed, 
            //only a new class is added, and MAINCLASS is changed
            //var dbMigrator = new DBMigrator(new ConsoleLogger()); 
            var dbMigrator = new DBMigrator(new FileLogger(@"/Users/kevinvong/Desktop/Visual Studio/CSharpIntermediate/CSharpIntermediate_Interfaces/Log.txt"));
            dbMigrator.Migrate();
        }
    }
}
