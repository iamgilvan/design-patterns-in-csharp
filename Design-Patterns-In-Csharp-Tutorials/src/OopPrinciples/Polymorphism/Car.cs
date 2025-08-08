namespace Design_Patterns_In_Csharp_Tutorials.Polymorphism
{
    public class Car : Vehicle
    {
        public int NumberOfDoors { get; set; }

        public override void Start()
        {
            Console.WriteLine("Car is starting.");
        }

        public override void Stop()
        {
            Console.WriteLine("Car is stopping.");
        }
    }
}