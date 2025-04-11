namespace PersonalFinanceApp.Domain.Entities
{
    public class Transaction
    {
        public Guid Id { get; private set; }
        public DateTime Date { get; private set; }
        public string Description { get; private set; }
        public decimal Amount { get; private set; }
        public TransactionType Type { get; private set; } // Income or Expense
        public Guid CategoryId { get; private set; }

        protected Transaction() { }

        public Transaction(Guid id, DateTime date, string description, decimal amount, TransactionType type, Guid categoryId)
        {
            Id = id;
            Date = date;
            Description = description;
            Amount = amount;
            Type = type;
            CategoryId = categoryId;
        }
    }

    public enum TransactionType
    {
        Income,
        Expense
    }
}

