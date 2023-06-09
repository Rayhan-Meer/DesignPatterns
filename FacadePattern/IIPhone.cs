﻿namespace Design_Patterns.FacadePattern
{
    public interface IIPhone
    {
        string Name { get; set; }
        int Quantity { get; set; }
        int Price { get; set; }
        string GetIPhone(string _name, int _quantity, int _price);
    }
}