using System;

namespace interfacesegregationprinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            IMovingAnimal d = new Dog("Rex");
            IFlyingAnimal b = new Bird("Tweety");

            d.Move();
            d.Run();

            Console.WriteLine();

            b.Move();
            b.Fly();
        }
    }
}
