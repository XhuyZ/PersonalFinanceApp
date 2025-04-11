namespace PersonalFinanceApp.Domain.Entities
{
    public class Budget
    {
        public Guid Id { get; private set; }
        public Guid CategoryId { get; private set; }
        public decimal Limit { get; private set; }
        public DateTime PeriodStart { get; private set; }
        public DateTime PeriodEnd { get; private set; }

        protected Budget() { }

        public Budget(Guid id, Guid categoryId, decimal limit, DateTime periodStart, DateTime periodEnd)
        {
            Id = id;
            CategoryId = categoryId;
            Limit = limit;
            PeriodStart = periodStart;
            PeriodEnd = periodEnd;
        }

        public bool IsWithinPeriod(DateTime date)
        {
            return date >= PeriodStart && date <= PeriodEnd;
        }
    }
}

