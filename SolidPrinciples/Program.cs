using SolidPrinciples.ISP.Classes;
using SolidPrinciples.LSP;
using SolidPrinciples.OCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Single Responsibility Principle");
            Console.WriteLine("-------------------------------");            

            // Single Responsibility Principle
            DataAccess.InsertData();
            Logger.WriteLog();
            Console.WriteLine("");

            Console.WriteLine("Open Closed Principle");
            Console.WriteLine("---------------------");

            // Open CLosed Principle
            Rectangle rectangle = new Rectangle
            {
                Width = 3,
                Height = 5
            };
            Console.WriteLine("Area of a rectangle "+ rectangle.Area());

            Circle circle = new Circle
            {
                Radius = 3
            };
            Console.WriteLine("Area of a circle " + circle.Area());

            Console.WriteLine("");

            Console.WriteLine("Liskov Substitution Principle");
            Console.WriteLine("---------------------");

            List<Customer> Customers = new List<Customer>();
            Customers.Add(new SilverCustomer());
            Customers.Add(new GoldCustomer());
            //Customers.Add(new Enquiry());//error

            Fruit fruit = new Orange();
            Console.WriteLine(fruit.GetColor());
            fruit = new Apple();
            Console.WriteLine(fruit.GetColor());

            Console.WriteLine("");

            Console.WriteLine("Interface Segregation Principle");
            Console.WriteLine("---------------------");

            ToyHouse toyHouse = new ToyHouse();
            toyHouse.Color();

            ToyTrain toyTrain = new ToyTrain();
            toyTrain.Run();
            toyTrain.Stop();

            Console.ReadLine();
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }


    public class Apple: Fruit
    {
        public override string GetColor()
        {
            return "Red";
        }
    }
    public class Orange : Apple
    {
        public override string GetColor()
        {
            return "Orange";
        }
    }



    
}
