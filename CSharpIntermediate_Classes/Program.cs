using System;

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

            //Testing Properties
            var personE = new Person();
            personE.AmountOfCarrots = 8;

            //Testing Indexers
            var cookie = new HttpCookie();
            cookie["help"] = "eight";
            Console.WriteLine(cookie["help"]);

            //Stopwatch
            var stopwatch = new Stopwatch();
            while(true)
            {
                Console.WriteLine("Option: ");
                Console.WriteLine("1. Set Start");
                Console.WriteLine("2. Set Stop");
                Console.WriteLine("3. Get Duration");
                Console.WriteLine("4. Quit");
                var opt = Char.GetNumericValue(Console.ReadLine()[0]);
                if (Math.Abs(opt - 4) < 0.1) break;
                switch(opt)
                {
                    case 1:
                        stopwatch.Start();
                        break;
                    case 2:
                        stopwatch.Stop();
                        break;
                    case 3:
                        Console.WriteLine(stopwatch.Duration());
                        break;
                }
            }
        }
    }
}
