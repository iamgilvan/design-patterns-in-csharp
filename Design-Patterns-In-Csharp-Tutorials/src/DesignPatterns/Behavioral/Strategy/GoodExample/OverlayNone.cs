using System;

namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class OverlayNone : IOverlay
    {
        public void Apply()
        {
            System.Console.WriteLine("Not applying an overlay");
        }
    }
}