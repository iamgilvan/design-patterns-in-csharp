using System;

namespace Design_Patterns_In_Csharp_Tutorials.OopPrinciples.Inheritance
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public void Start()
        {
            Console.WriteLine("Vehicle is starting.");
        }
        public void Stop()
        {
            Console.WriteLine("Vehicle is stopping.");
        }
    }
}