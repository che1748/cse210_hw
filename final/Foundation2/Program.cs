using System;

class Program
{
    static void Main(string[] args)
    {
        Address myAddress = new Address("525 Center Street", "Rexburg", "Idaho", "USA");
        Address hisAddress = new Address("1404 Hanghai Road", "Zhengzhou", "Henan", "China");

        Customer me = new Customer("Andrew", myAddress);
        Customer friend = new Customer("Li Hua", hisAddress);

        Product plasticBag = new Product("Plastic bag","A0304", 0.12, 300);
        Product waterBottle = new Product("Water bottle", "B2745", 10.37, 50);
        Product pen = new Product("pen", "C1132", 2, 45);

        Order myOrder = new Order(me);
        myOrder.AddProduct(plasticBag);
        myOrder.AddProduct(waterBottle);
        myOrder.AddProduct(pen);

        Order hisOrder = new Order(friend);
        hisOrder.AddProduct(waterBottle);
        hisOrder.AddProduct(pen);

        Order ord = new Order(me);

        List<Order> orderList = new List<Order>()
        {myOrder, hisOrder, ord};

        foreach (Order order in orderList)
        {
            Console.WriteLine("Packing label:");
            order.DisplayPackingLabel();

            Console.WriteLine("Shipping label:");
            Console.WriteLine(order.GetShippingLabel());

            Console.WriteLine($"The total price of the order is ${order.GetOrderTotalCost()}\n\n\n");
        }
    }
}