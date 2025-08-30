namespace Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Iterator.GoodExample
{
    public interface IIterator<T>
    {
        void Next();
        bool HasNext();
        // String Current(); // PROBLEM: what if don't always wanna iterate over strings? E.g. Customers or integers.
        T Current(); // SOLUTION: Use a Generic type
    }
}