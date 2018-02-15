using CSharpIntermediate_Inheritance_Internal;

namespace CSharpIntermediate_Inheritance
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Public
            var customer = new Customer();
            customer.Promote();

            //Internal - Cannot access due to protection level
            /*var rating = new CalculateRating();*/

            //Constructors Inheritance
            var car = new Car("111");
        }
    }
}
