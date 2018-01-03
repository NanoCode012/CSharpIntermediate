using System;
using System.Collections.Generic;

namespace CSharpIntermediate_Classes
{
    class Person
    {
        public string name;//making a setter method should be better, than making 
        public int id;     //these public

        public readonly List<Order> Orders;//using readonly to protect code from developer accidentally initializing again

        private DateTime _birthDate;

		private int _carrots;

        public TimeSpan TimeTillEndYear { get; set; }//this is a auto-implemented property, easy way to get/set
        public string Name { get; set; }//use prop as code-snippet

        //Constructors
        //Only define constructors when it is a MUST, else they clog the code
        //for eg, only this first constructor is necessary, every other is optional
        public Person()
        {
            Orders = new List<Order>();//this is not recommended, an easier way is to initialize while declaration
        }

        public Person(string name) : this()//doing this() makes code hard to read
        {
            this.name = name;
        }

        public Person(string name, int id) : this(name)//doing this() makes code hard to read
        {
            this.id = id;
        }

        public int AmountOfCarrots //this is a normal property, quicker way to get/set without typing two whole methods
        {
            get
            {
                return _carrots;
            }
            set
            {
                _carrots = value;
            }
        }

        public TimeSpan TimeFromBeginningYear//this is a property that does not allow to set its value
        {
            get
            {
                return new TimeSpan(365, 0, 0, 0) - TimeTillEndYear;
            }
        }


        public static Person CreatePersonWithName(string name)
        {
            var person = new Person();
            person.name = name;
            return person;
        }

        public void Introduce()
        {
            Console.WriteLine("My name is {0}", name);
        }

        public void SetBirthDate(int day, int month, int year){
            _birthDate = new DateTime(year, month, day);
        }

        public DateTime GetBirthDay(){
            return _birthDate;
        }
    }
}
