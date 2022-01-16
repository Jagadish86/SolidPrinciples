using System;

namespace SolidPrinciples.LooseCoupling
{
    public class CustomerRepository
    {
        private readonly IDatabase database;
        public CustomerRepository(IDatabase database)
        {
            this.database = database;
        }
        public void Add(string CustomerName)
        {
            database.AddRow("Customer", CustomerName);
        }
    }
    public interface IDatabase
    {
        void AddRow(string Table, string Value);
    }
    public class SqlDatabase : IDatabase
    {
        public void AddRow(string Table, string Value)
        {
            //Logic to add new customer in sql table  
            Console.WriteLine($"{ Table },  { Value }");
        }
    }
    public class XMLDatabase : IDatabase
    {
        public void AddRow(string Table, string Value)
        {
            //Logic to add new customer in XML Document
            Console.WriteLine($"{ Table },  { Value }");
        }
    }
}
