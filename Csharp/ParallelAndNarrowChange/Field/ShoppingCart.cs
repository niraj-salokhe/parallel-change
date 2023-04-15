using System.Collections.Generic;
using System.Linq;

namespace ParallelAndNarrowChange.Field
{
    public class ShoppingCart{
        private List<decimal> price;

        public ShoppingCart()
        {
            price = new List<decimal>();
        }

        public decimal CalculateTotalPrice(){
            return price.Sum();
        }

        public bool HasDiscount(){
            return price.Sum() > 100;
        }

        public void Add(int aPrice){
            this.price.Add(aPrice);
        }

        public int NumberOfProducts(){
            return price.Count;
        }
    }
}
