using System;
namespace CSharpIntermediate_Inheritance_Internal
{
    public class Customer
    {
        public int Name { get; set; }
        public int ID { get; set; }

        public void Promote()
        {
            CalculateRating calc = new CalculateRating();//This creates coupling, not good. Later use Interfaces to improve on this.
            if (calc.GetRating() > 0) Console.WriteLine("Promoted");
            else Console.WriteLine("Not Promoted");
        }
    }
}
