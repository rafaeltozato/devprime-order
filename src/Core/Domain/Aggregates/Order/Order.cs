namespace Domain.Aggregates.Order;
public class Order : AggRoot
{
    public string CustomerName { get; private set; }
    public string CustomerTaxID { get; private set; }
    public IList<Item> Items { get; private set; }
    public double Total { get; private set; }
    public void AddItem(Item item)
    {
        if (item != null && Items != null)
        {
            var myItems = Items.Where(p => p.SKU == item.SKU).FirstOrDefault();
            if (myItems != null)
                myItems.Sum(item.Amount);
            else
                Items.Add(item);
        }
    }
}