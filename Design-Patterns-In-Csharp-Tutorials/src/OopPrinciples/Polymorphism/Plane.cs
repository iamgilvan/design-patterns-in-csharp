using System;

namespace Design_Patterns_In_Csharp_Tutorials.Polymorphism
{
    public class Plane : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Plane is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Plane is stopping.");
        }
    }
}