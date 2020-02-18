using System;

namespace interfacesegregationprinciple
{
    class Program
    {
        static void Main(string[] args)
        {
            Dog d = new Dog("Rex");
            Bird b = new Bird("Tweety");

            d.Move();
            d.Run();
            d.Fly();

            Console.WriteLine();

            b.Move();
            b.Run();
            b.Fly();
        }
    }
}
