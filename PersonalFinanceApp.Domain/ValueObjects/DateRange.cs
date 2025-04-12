namespace PersonalFinanceApp.Domain.ValueObjects
{
    public class DateRange
    {
        public DateTime Start { get; }
        public DateTime End { get; }

        public DateRange(DateTime start, DateTime end)
        {
            if (end < start)
                throw new ArgumentException("End must be after Start");
            Start = start;
            End = end;
        }

        public bool Contains(DateTime date) => date >= Start && date <= End;
    }
}

