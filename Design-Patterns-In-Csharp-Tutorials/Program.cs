// State Pattern

using Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.State.GoodExample;

var doc = new Document(UserRoles.EDITOR);
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);

doc.Publish();
System.Console.WriteLine(doc.State);