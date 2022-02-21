using System;

namespace Task3
{
    public class ShopNotFoundException : Exception
    {
        public ShopNotFoundException() { }
        public ShopNotFoundException(string message) : base(message) { }
    }
}
