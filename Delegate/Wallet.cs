namespace Delegate;

public class Wallet
{
    public int Id { get; set; }
    public List<Quote> Quotes { get; set; } = new List<Quote>();
}