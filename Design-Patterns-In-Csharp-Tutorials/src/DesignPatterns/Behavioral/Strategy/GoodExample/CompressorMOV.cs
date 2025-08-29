using System;

namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Strategy.GoodExample
{
    public class CompressorMOV : ICompressor
    {
        public void Compress()
        {
            System.Console.WriteLine("Compressing video using MOV");
        }
    }
}