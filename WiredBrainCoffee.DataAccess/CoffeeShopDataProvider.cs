using System.Collections.Generic;

namespace WiredBrainCoffee.DataAccess
{
    public class CoffeeShopDataProvider
    {
        public IEnumerable<CoffeeShop> LoadCoffeeeShops()
        {
            yield return new CoffeeShop { Location = "Munich", BeansInStockInKg = 56 };
            yield return new CoffeeShop { Location = "Freiburg", BeansInStockInKg = 23 };
            yield return new CoffeeShop { Location = "Frankfurt", BeansInStockInKg = 107 };

        }
    }
}
