using System;

public class product
{
    private string _name;
    private string _product;
    private double _price;
    private int _quantity;

    public product(string name, string id, double price, int quantity)
    {
        _name = name;
        _product = id;
        _price = price;
        _quantity = quantity;
    }

    public double GetTotalCost()
    {
        return _price * _quantity;
    }

    public string GetPackingInfo()
    {
        return $"{_name} (ID: {_product})";
    }
}