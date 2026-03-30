using System.Collections.Generic;
using System;

public class Order
{
    private List<product> _products = new List<product>();
    private Customer _customer;

    public Order(Customer customer)
    {
        _customer = customer;
    }

    public void AddProduct(product product)
    {
        _products.Add(product);
    }

    public double CalculateTotalCost()
    {
        double totalCost = 0;
        foreach (var product in _products)
        {
            totalCost += product.GetTotalCost();
        }
        
        if (_customer.GetAddress().GetCountry() != "USA")
        {
            totalCost += 5; // Shipping cost for international orders
        }
        return totalCost;
    }


    public string GetPackingLabel()
    {
        string packingLabel = "Packing Label:\n";
        foreach (var product in _products)
        {
            packingLabel += $"{product.GetPackingInfo()}\n";
        }
        return packingLabel;
    }

    public string GetShippingLabel()
    {
        Address address = _customer.GetAddress();
        return $"Shipping Label:\n{_customer.GetName()}\n{address.GetStreet()}\n{address.GetCity()}, {address.GetState()} {address.GetCountry()}";
    }
}