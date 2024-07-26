using System;
using System.Collections.Generic;
using System.Linq;

namespace BankApp
{
    public class Bank
    {
        private List<Customer> customers = new List<Customer>();
        private int nextId = 1;

        // Menampilkan semua nasabah
        public void DisplayCustomers()
        {
            if (customers.Count == 0)
            {
                Console.WriteLine("No customer available");
            }
            else 
            {
                foreach (var customer in customers)
                {
                    customer.DisplayInfo();
                }
            }
        }

        // Menambahkan nasabah baru
        public void AddCustomer(string name, double initialBalance)
        {
            var customer = new RegularCustomer(nextId++, name, initialBalance);
            customers.Add(customer);
            Console.WriteLine("Customer added successfully");
        }

        // Menghapus nasabah berdasarkan ID
        public void DeleteCustomer(int id)
        {
            var customer = customers.FirstOrDefault(c => (c as Customer).Id == id);
            if (customer != null)
            {
                customers.Remove(customer);
                Console.WriteLine("Customer deleted successfully");
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }

        // Mengubah data nasabah  berdasarkan ID
        public void UpdateCustomer(int id, string newName, double newBalance)
        {
            var customer = customers.FirstOrDefault(c => (c as Customer).Id == id);
            if (customer != null)
            {
                customer.Name = newName;
                customer.Balance = newBalance;
                Console.WriteLine("Customer updated successfully");
            }
            else
            {
                Console.WriteLine("Customer not found");
            }
        }
    }
}