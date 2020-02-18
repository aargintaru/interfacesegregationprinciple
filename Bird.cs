using System;

namespace interfacesegregationprinciple
{
    internal class Bird : IFlyingAnimal
    {
        private string name;

        public Bird(string name)
        {
            this.name = name;
        }

        public void Fly()
        {
            Console.WriteLine($"{name} flies from A to B");
        }

        public void Move()
        {
            Console.WriteLine($"{name} moves from A to B");
        }
    }
}