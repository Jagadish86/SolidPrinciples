using SolidPrinciples.ISP.Interfaces.Order;
using System;

namespace SolidPrinciples.ISP.Classes.Order
{
    public class OfflineOrder : IOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
            Console.WriteLine("Do Add To Cart");
        }
    }
}
