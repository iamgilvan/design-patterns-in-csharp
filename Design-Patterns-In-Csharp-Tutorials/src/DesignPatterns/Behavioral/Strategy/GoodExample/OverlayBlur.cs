using System;

namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayBlur : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Applying blur overlay");
        }
    }
}