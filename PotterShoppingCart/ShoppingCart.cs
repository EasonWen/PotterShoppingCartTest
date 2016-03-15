using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace PotterShoppingCart
{
    public class ShoppingCart
    {
        private List<int> _order = new List<int>();

        public double CheckOut()
        {
            double totalPrice= 0; 
            
            while (_order.Count > 0)
            {
                var uniqueItems = new HashSet<int>(_order); //過濾連續買的集數
                var discount = Discount(uniqueItems.Count); //折扣
                foreach (var item in uniqueItems)
                {
                    _order.Remove(item);
                }

                totalPrice += (100 * uniqueItems.Count) * discount;
            }

            return totalPrice;
        }

        public void AddBookSetToCar(int bookSetNum)
        {
            _order.Add(bookSetNum);
        }

        private double Discount(int bookAmount)
        {
            double discount = 1;

            switch (bookAmount)
            {
                case 2:
                    return discount = 0.95;
                case 3:
                    return discount = 0.90;
                case 4:
                    return discount = 0.80;
                case 5:
                    return discount = 0.75;
            }
            return discount;
        }



    }

}
