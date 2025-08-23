using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.D.BetterExample
{
    public class Car
    {
        private IEngine engine;

        public Car(IEngine engine)
        {
            this.engine = engine;
        }

        public void StartCar()
        {
            engine.Start();
            System.Console.WriteLine("Car started.");
        }
    }
}