using System;

namespace Task3
{
    class Program
    {
        static private Price[] prices = new Price[2];
        static void Main(string[] args)
        {

            for (int i = 0; i < prices.Length;)
            {
                Console.WriteLine("Введите данные о ценах в формате [Название товара;Название машазина;Цена]");
                string[] inputString = Console.ReadLine().Split(';');
                try
                {
                    prices[i] = new Price(inputString[0], inputString[1], inputString[2]);
                    i++;
                }
                catch (IndexOutOfRangeException e)
                {
                    Console.WriteLine("Используйте следующий формат [Название товара;Название машазина;Цена]. Ошибка: " + e.Message);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }
            Array.Sort(prices);

            Console.WriteLine("Укажите требуемы магазин для поиска товара.");
            string filter = Console.ReadLine();
            try
            {
                PrintShopPrices(filter);
            }
            catch (ShopNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        static public void PrintShopPrices(string shopName)
        {
            bool flag = true;
            Console.WriteLine($"Товары магазина {shopName}:");
            foreach (var item in prices)
            {
                if (item.shopName == shopName)
                {
                    Console.Write(item.GetInfo());
                    flag = false;
                }
            }
            if (flag)
                throw new ShopNotFoundException("Указанный магазин не найден");
        }
    }
}
