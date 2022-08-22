namespace Domain.Aggregates.Order;
public class Item : Entity
{
    public string Description { get; private set; }
    public int Amount { get; private set; }
    public string SKU { get; private set; }
    public double Price { get; private set; }
    public double GetSubTotal()
    {
        return Amount * Price;
    }

    public void Sum(int amount)
    {
        Amount += amount;
    }
}