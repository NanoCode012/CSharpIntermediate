using System;

namespace CSharpIntermediate_Inheritance
{
    class Vehicle
    {
        //public Vehicle()
        //{
        //    Console.WriteLine("Vehicle is initialized");
        //}

        readonly string registrationNumber;

        public Vehicle(string registrationNumber)
        {
            this.registrationNumber = registrationNumber;
            Console.WriteLine("Vehicle is being initialized {0}", registrationNumber);
        }
    }
}
