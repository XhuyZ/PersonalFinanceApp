namespace PersonalFinanceApp.Domain.Entities
{
    public class Category
    {
        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public TransactionType Type { get; private set; } // For Income or Expense

        protected Category() { }

        public Category(Guid id, string name, TransactionType type)
        {
            Id = id;
            Name = name;
            Type = type;
        }
    }
}

