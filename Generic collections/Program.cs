namespace Generic_collections;

class Program
{
    static void Main(string[] args)
    {
        Restaurant restaurant = new Restaurant();

        // 4 dishes
        restaurant.AddToMenu("Meatloaf", 30);
        restaurant.AddToMenu("Pasta carbonara", 20);
        restaurant.AddToMenu("Hot dog", 10);
        restaurant.AddToMenu("Spaghetti bolognese", 15);

        // menu
        restaurant.ShowMenu();

        // 3 orders
        restaurant.CreateOrder(new List<string>
        {
            "Meatloaf",
            "Pasta carbonara"
        }, 1);

        restaurant.CreateOrder(new List<string>
        {
            "Hot dog",
            "Spaghetti bolognese"
        }, 2);

        restaurant.CreateOrder(new List<string>
        {
            "Meatloaf",
            "Hot dog",
            "Pasta carbonara"
        }, 3);

        // show orders
        restaurant.ShowOrders();

        // order count
        restaurant.ShowOrderCount();

        // next order
        restaurant.ShowNextOrder();

        // handle order
        restaurant.HandleOrder();

        // order count
        restaurant.ShowOrderCount();

        // add order
        restaurant.CreateOrder(new List<string>
        {
            "Spaghetti bolognese",
            "Meatloaf"
        }, 4);

        // order count
        restaurant.ShowOrderCount();

        // handle 2 orders
        restaurant.HandleOrder();
        restaurant.HandleOrder();

        // order count
        restaurant.ShowOrderCount();

        // show next order
        restaurant.ShowNextOrder();

        // handle order
        restaurant.HandleOrder();

        // final count
        restaurant.ShowOrderCount();
    }
}