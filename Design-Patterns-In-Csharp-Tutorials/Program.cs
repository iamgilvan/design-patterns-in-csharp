// Iterator Pattern

// The Iterator Pattern provides a way of iterating over an object without having to expose the object's
// internal structure, which may change in the future. Changing the internals of an object should not affect its consumers.

using Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Iterator.GoodExample;

ShoppingList list = new ShoppingList();
list.Push("Milk");
list.Push("Bread");
list.Push("Steak");

var iterator = list.CreateIterator();
while (iterator.HasNext())
{
    System.Console.WriteLine(iterator.Current());
    iterator.Next();
}
