// Encapsulation

using Design_Patterns_In_Csharp_Tutorials.OopPrinciples.Encapsulation;

BankAccount BankAccount = new BankAccount(100);
System.Console.WriteLine(BankAccount.GetBalance());
BankAccount.Deposit(50);
System.Console.WriteLine(BankAccount.GetBalance());
BankAccount.Withdraw(200);
System.Console.WriteLine(BankAccount.GetBalance());

// BadBankAccount badBankAccount = new BadBankAccount();
// badBankAccount.balance = 100;
// System.Console.WriteLine(badBankAccount.balance);