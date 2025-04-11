namespace PersonalFinanceApp.Domain.Entities;

public class User
{
    public Guid Id { get; private set; }
    public string Username { get; private set; }
    public string Email { get; private set; }

    // private List<Wallet> _wallets = new();
    private List<Wallet> _wallets = new();
    public IReadOnlyCollection<Wallet> Wallets => _wallets.AsReadOnly();

    protected User() { }

    public User(Guid id, string username, string email)
    {
        Id = id;
        Username = username;
        Email = email;
    }

    public void AddWallet(Wallet wallet)
    {
        _wallets.Add(wallet);
    }
}
