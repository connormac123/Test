using System.Collections.Generic;

public class Order
{
    public List<Product> Products { get; set; }
    public Customer Customer { get; set; }

    public Order(List<Product> products, Customer customer)
    {
        Products = products;
        Customer = customer;
    }

    public double GetTotalPrice()
    {
        double totalPrice = 0;
        foreach (Product product in Products)
        {
            totalPrice += product.GetTotalPrice();
        }
        if (Customer.IsInUSA())
        {
            totalPrice += 5;
        }
        else
        {
            totalPrice += 35;
        }
        return totalPrice;
    }
}
