using SolidPrinciples.ISP.Interfaces.Order;
using System;

namespace SolidPrinciples.ISP.Classes.Order
{
    public class OnlineOrder : IOrder, IOnlineOrder
    {
        public void AddToCart()
        {
            //Do Add to Cart
            Console.WriteLine("Do Add To Cart");
        }

        public void CCProcess()
        {
            // Process through credit card
            Console.WriteLine("Process through credit card");
        }
    }
}
