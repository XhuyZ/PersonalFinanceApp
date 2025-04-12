namespace PersonalFinanceApp.Domain.ValueObjects
{
    public class Email : IEquatable<Email>
    {
        public string Value { get; }

        public Email(string value)
        {
            if (!IsValidEmail(value))
                throw new ArgumentException("Invalid email format");
            Value = value;
        }

        private bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[^@\s]+@[^@\s]+\.[^@\s]+$");
        }

        public bool Equals(Email? other)
        {
            return other != null && Value.Equals(other.Value, StringComparison.OrdinalIgnoreCase);
        }

        public override bool Equals(object? obj) => Equals(obj as Email);
        public override int GetHashCode() => Value.ToLowerInvariant().GetHashCode();
    }
}

