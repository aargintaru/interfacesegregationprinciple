using System;

namespace interfacesegregationprinciple
{
    public class Dog : IMovingAnimal
    {
        private string name;

        public Dog(String name)
        {
            this.name = name;
        }

        public void Move()
        {
            Console.WriteLine($"{name} moves from A to B");
        }

        public void Run()
        {
            Console.WriteLine($"{name} runs from A to B");
        }
    }
}