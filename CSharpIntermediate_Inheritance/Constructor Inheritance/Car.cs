using System;

namespace CSharpIntermediate_Inheritance
{
    class Car : Vehicle
    {
        public Car(string registrationNumber) : base(registrationNumber)
        {
            Console.WriteLine("Car is initialized {0}", registrationNumber);
        }
    }
}
