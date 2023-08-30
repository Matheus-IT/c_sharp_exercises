var account = new BankAccount("Matheus", 10000);
account.MakeWithdrawal(50, "Hammock");
try {
    account.MakeDeposit(-150, "Stealing");
} catch (ArgumentOutOfRangeException e) {}

Console.WriteLine($"Account {account.Number} was created for {account.Owner} with ${account.Balance}");
