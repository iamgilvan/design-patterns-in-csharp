// Coupling

// The degree of dependency between different classes
using Design_Patterns_In_Csharp_Tutorials.Coupling;

var order = new Order(new SmsSender());
order.PlaceOrder();