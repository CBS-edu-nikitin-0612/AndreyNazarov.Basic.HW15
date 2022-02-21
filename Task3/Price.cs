using System;

namespace Task3
{
    internal struct Price : IComparable<Price>
    {
        private string name;
        public string shopName { get; private set; }
        private decimal price;

        public Price(string name, string shopName, string price)
        {
            this.name = name;
            this.shopName = shopName;
            this.price = decimal.Parse(price);
        }
        public int CompareTo(Price other)
        {
            return shopName.CompareTo(other.shopName);
        }
        public string GetInfo()
        {
            return $"Название товара: {name}\nЦена: {price}\n";
        }
    }
}
