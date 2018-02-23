using CSharpIntermediate_Inheritance_Internal;
using System;

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


			//Upcasting - Cast from Derived(Child) to Base(Parent) class
            Text text = new Text();
            Shape shape = text;
            text.Width = 200;
            shape.Width = 100;
			//They both are referencing to the same objects but with different Views
            //Shape allow less functions than Text
            Console.WriteLine(text.Width);


            //Downcasting - Cast from Base(Parent) to Derived(Child) class
            Shape shap = new Text();
            Text txt = (Text)shap;//Needs explicit cast

            Text txt2 = shap as Text;//Another way of doing it, but safer
            if (txt2 != null) {} //Check if txt2's cast was successful
            if (txt2 is Text) {} //Check if txt2's cast was successful


            //Boxing - Cast from value type to reference type - Move memory allocation from stack to heap - Performance Penalty
            int num = 10;
            object obj = num;


            //Unboxing - Cast from reference type to value type - Performance Penalty
            int number = (int)obj;

            //Stack example
            var stack = new Stack<int>();
            stack.Push(5);
            stack.Push(3);
            stack.Push(8);
            stack.Push(10);
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Pop());
            Console.WriteLine(stack.Peek());
        }
    }
}
