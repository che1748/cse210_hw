using System;
using System.Dynamic;

public class Order
{
    private List<Product> _productList = new List<Product>();
    private Customer _customer;

    public Order(Customer costumer)
    {
        _customer = costumer;
    }

    public void AddProduct(Product product)
    {
        _productList.Add(product);
    }

    public double GetOrderTotalCost()
    {
        double total = 0;
        foreach (Product product in _productList)
        {
            total += product.GetProductTotalCost();
        }
        if (_customer.LiveInUSA())
        {total += 5;}
        else
        {total += 35;}
        return Math.Round(total,2);
    }

    public void DisplayPackingLabel()
    {
        foreach (Product product in _productList)
        {
            //Console.WriteLine($"Product name: {product.GetName()}  Product ID: {product.GetID()}");
            string string1 = $"{product.GetName()}";
            string string2 = $"{product.GetID()}";
            Console.WriteLine(String.Format("Product name: {0,-20} Product ID: {1,-20}", string1 + "", string2));
        }

    }

    public string GetShippingLabel()
    {
        return $"name: {_customer.GetName()}\nAddress: {_customer.GetAddress()}\n";
    }
}