using SolidPrinciples.ISP.Classes;
using SolidPrinciples.LooseCoupling;
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
        enum MessaeQueue
        {
            Rabbit = 10,
            ApacheKafka = 18
        }
        const int const_workHours = 8;
        static readonly int readonly_workHours;
        static Program()
        {
            readonly_workHours = 10;
        }
        static void Main(string[] args)
        {
            
            Console.WriteLine($"Employee work hour for a day is {readonly_workHours}");
            Console.WriteLine($"Employee work hour for a day is {const_workHours}");

            var days = new List<int>();
            days.AddRange(new List<int> { 1, 2, 3, 4, 5, 6, 7 });

            var daysThatAreOdd = days.Where(x => x % 2 != 0);
            var daysThatAreEven = days.Where(x => x % 2 == 0);

            // Loose Coupling using Interfaces
            CustomerRepository cr;

            cr = new CustomerRepository(new SqlDatabase());
            cr.Add("Jagadish");

            cr = new CustomerRepository(new XMLDatabase());
            cr.Add("Palanivelu");

            IBank bank = new Chase();
            bank.Connect(); // Connect to bank BankOfAmerica

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
            Console.WriteLine("Area of a rectangle " + rectangle.Area());

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

            BMW b = new BMW();
            b.StartEngine();
            b.StopEngine();

            Console.ReadLine();
        }
    }

    public abstract class Vehicle
    {
        public void StartEngine() { }
    }

    public abstract class Car : Vehicle
    {
        public void StopEngine() { }
    }

    public class BMW : Car
    {

    }

    public interface IBank
    {
        void Connect();
    }


    public class Chase : IBank
    {
        public void Connect()
        {
            Console.WriteLine($"Connect to bank {this.GetType().Name}");
        }
    }

    public class BankOfAmerica : IBank
    {
        public void Connect()
        {
            Console.WriteLine($"Connect to bank {this.GetType().Name}");
        }
    }
    public abstract class Fruit
    {
        public abstract string GetColor();
    }


    public class Apple : Fruit
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
