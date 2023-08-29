var account = new BankAccount("Matheus", 10000);
account.MakeWithdrawal(50, "Hammock");
Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
