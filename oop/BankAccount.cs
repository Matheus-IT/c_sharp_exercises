class BankAccount {
    public string Number { get; }
    public string Owner { get; set; }
    public decimal Balance {
        get {
            decimal balance = 0;
            foreach (var t in allTransactions) {
                balance += t.Amount;
            }
            return balance;
        }
    }
    public List<Transaction> allTransactions = new List<Transaction>();

    public BankAccount(string name, decimal initialBalance) {
        this.Number = new Random().Next(100).ToString();
        this.Owner = name;
        this.MakeDeposit(initialBalance, DateTime.Now, "Initial Balance");
    }

    public void MakeDeposit(decimal amount, DateTime date, string note) {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
        var deposit = new Transaction(amount, date, note);
        allTransactions.Add(deposit);
    }
    public void MakeDeposit(decimal amount, string note) {
        this.MakeDeposit(amount, DateTime.Now, note);
    }

    public void MakeWithdrawal(decimal amount, DateTime date, string note) {
        if (amount <= 0)
            throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
        if (Balance - amount < 0)
            throw new InvalidOperationException("Not sufficient funds for this withdrawal");
        var withdrawal = new Transaction(-amount, date, note);
        allTransactions.Add(withdrawal);
    }
    public void MakeWithdrawal(decimal amount, string note) {
        this.MakeWithdrawal(amount, DateTime.Now, note);
    }
}