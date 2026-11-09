namespace Generic_collections;

public class Order
{
    // I denna klass använder vi i stället private fields
    static int orderIdCounter = 1;
    private int _orderId;
    private List<MenuItem> _orderItems;
    private int _tableNumber;
    
    public int OrderId => _orderId;
    public int TableNumber => _tableNumber;

    public IReadOnlyList<MenuItem> OrderItems => _orderItems;

    public Order(List<MenuItem> orderItems, int tableNumber)
    {
        // Automatiskt skapande av id
        _orderId = orderIdCounter;
        orderIdCounter++;
        _orderItems = orderItems;
        _tableNumber = tableNumber;
    }
    
    public override string ToString()
    {
        string result = $"Order #{_orderId} - Table {_tableNumber}\n";

        foreach (MenuItem item in _orderItems)
        {
            result += $"- {item.Name} - {item.Price:C}\n";
        }

        return result;
    }
}