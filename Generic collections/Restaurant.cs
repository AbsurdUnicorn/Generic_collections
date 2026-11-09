namespace Generic_collections;

public class Restaurant
{
    private static List<MenuItem> Menu = new List<MenuItem>();

    private static Queue<Order> OrdersQueue = new Queue<Order>();

    public void AddToMenu(string name, decimal price)
    {
        int id = Menu.Count + 1;
        MenuItem item = new MenuItem(id, name, price);
        Menu.Add(item);
        
        Console.WriteLine($"{name} has been added to the menu at a price of {price}");
    }

    public void ShowMenu()
    {
        foreach (var item in Menu)
        {
            Console.WriteLine($"{item.Name} - ${item.Price}");
        }
    }

    public void CreateOrder(List<string> items, int tableNumber)
    {
        List<MenuItem> orderedItems = new List<MenuItem>();

        foreach (var item in items)
        {
            foreach (var menuItem in Menu)
            {
                if (menuItem.Name.Equals(item, StringComparison.OrdinalIgnoreCase))
                {
                    orderedItems.Add(menuItem);
                    break;
                }
            }
        }

        Order order = new Order(orderedItems, tableNumber);

        OrdersQueue.Enqueue(order);

        Console.WriteLine($"A new order for table {tableNumber} has been created.");
    }

    public void HandleOrder()
    {
        if (OrdersQueue.Count == 0)
        {
            Console.WriteLine("No orders to handle.");
            return;
        }

        Order order = OrdersQueue.Dequeue();

        Console.WriteLine("Order has been handled:");
        Console.WriteLine(order);
    }

    public void ShowOrders()
    {
        if (OrdersQueue.Count == 0)
        {
            Console.WriteLine("There are currently no orders.");
            return;
        }

        foreach (Order order in OrdersQueue)
        {
            Console.WriteLine(order);
        }
    }

    public void ShowNextOrder()
    {
        if (OrdersQueue.Count == 0)
        {
            Console.WriteLine("There are no orders in the queue.");
            return;
        }

        Console.WriteLine("Next order:");
        Console.WriteLine(OrdersQueue.Peek());
    }

    public void ShowOrderCount()
    {
        Console.WriteLine($"There are currently {OrdersQueue.Count} orders in the queue.");
    }
}