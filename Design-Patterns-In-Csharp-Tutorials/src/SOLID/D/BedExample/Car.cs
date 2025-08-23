using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.D.BadExample
{
    public class Car
    {
        private Engine engine;

        public Car()
        {
            this.engine = new Engine(); // Direct dependency on Engine class
        }

        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}