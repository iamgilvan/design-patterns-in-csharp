using System;

namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorWebM : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using WebM");
        }
    }
}