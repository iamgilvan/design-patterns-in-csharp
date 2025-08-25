// Memento

// The memento Pattern is used to restore an object to a previous state

using Design_Patterns_In_Csharp_Tutorials.DesignPatterns.Behavioral.Memento.GoodExample;

var editor = new Editor();
var history = new History(editor);
history.Backup();
editor.Title = "Test";
history.Backup();
editor.Content = "Hello there, my name is Dan";
history.Backup();
editor.Title = "The life of a dev: my mementos";

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);

history.Undo();

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);

history.ShowHistory();

history.Undo();

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);

history.Undo();

System.Console.WriteLine("Title: " + editor.Title);
System.Console.WriteLine("Content: " + editor.Content);