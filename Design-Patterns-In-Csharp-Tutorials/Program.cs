// Interface Segregation  Principle (ISP)

// "Clients should not be forced to depend on interfaces they do not use."

using Design_Patterns_In_Csharp_Tutorials.SOLID.I.BadExample;

var circle = new Circle();
circle.Radius = 10;
System.Console.WriteLine(circle.Area());