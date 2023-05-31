using System;

namespace Inheritance
{
    // base class
    class Animal
    {
        public string name;
        public void display()
        {
            Console.WriteLine("I am an animal");
        }
    }

    // derive  class of Animal
    class Dog : Animal
    {
        public void getName()
        {
            Console.WriteLine("My name is " + name);

        }
    }

    class Crocodile : Animal
    {
        public void getName()
        {
            Console.WriteLine("I am " + name); 
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // object of derive class
            Dog labrador = new Dog();

            Crocodile lacoste = new Crocodile();

            //Accessing field and method of base class
            labrador.name = "Rohu";
            labrador.display();

            lacoste.name = "Gun";
            lacoste.display();

            //access method from own class 
            labrador.getName();
            lacoste.getName();

            Console.ReadLine();
        }
    }
}
