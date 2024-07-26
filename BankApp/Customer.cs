using System;

namespace BankApp
{
    // Implementasi interface ICustomer
    public class Customer : ICustomer
    {
        // Properti untuk enkapsulasi
        public int Id { get; private set;}
        public string Name { get; set; }
        public double Balance { get; set; }

        // Konstruktor
        public Customer(int id, string name, double balance)
        {
            Id = id;
            Name = name;
            Balance = balance;
        }

        // Metode virtual untuk polymorphsim
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Balance: {Balance:C}");
        }
    }
}