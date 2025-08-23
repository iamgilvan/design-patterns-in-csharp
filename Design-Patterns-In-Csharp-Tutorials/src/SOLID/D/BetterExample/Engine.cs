using System;

namespace Design_Patterns_In_Csharp_Tutorials.SOLID.D.BetterExample
{
    public class Engine: IEngine // our "low-level" module
    {
        public void Start()
        {
            System.Console.WriteLine("Engine started.");
        }
    }
}