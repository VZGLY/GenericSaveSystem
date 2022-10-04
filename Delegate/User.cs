namespace Delegate;

public class User
{
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Wallet> Wallets { get; set; } = new List<Wallet>()
    {
        new Wallet()
        {
            Quotes = new List<Quote>()
            {
                new Quote(),
                new Quote()
            }
        },
        new Wallet()
    };
}