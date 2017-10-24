namespace CSharpIntermediate_Classes
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Instantiating Person class in several ways with same results
            //Method 1 - Using a constructor overload
            var personA = new Person("Charles");
            //Method 2 - Using a static
            var personB = Person.CreatePersonWithName("Hordon");
            //Method 3 - Using object initialization
            var personC = new Person
            {
                name = "Iode"
            };
            //Method 4 - Using normal method
            var personD = new Person();
            personD.name = "Treag";

            //Output - Introduction
            personA.Introduce();
            personB.Introduce();
            personC.Introduce();
            personD.Introduce();


        }
    }
}
