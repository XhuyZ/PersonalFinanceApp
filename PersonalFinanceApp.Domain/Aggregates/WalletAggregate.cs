using PersonalFinanceApp.Domain.Entities;
namespace PersonalFinanceApp.Domain.Aggregates
{
    public class WalletAggregate
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public decimal Balance { get; private set; }

        private readonly List<Transaction> _transactions = new();
        public IReadOnlyCollection<Transaction> Transactions => _transactions.AsReadOnly();

        protected WalletAggregate() { }

        public WalletAggregate(Guid id, string name, decimal initialBalance = 0)
        {
            Id = id;
            Name = name;
            Balance = initialBalance;
        }

        public void AddTransaction(Transaction transaction)
        {
            _transactions.Add(transaction);

            Balance += transaction.Type == TransactionType.Income
                ? transaction.Amount
                : -transaction.Amount;
        }
    }
}

