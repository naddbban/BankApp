using System;

namespace BankApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();
            int choice;

            do
            {
                Console.WriteLine("\nBank Application Menu");
                Console.WriteLine("1. Display all customers");
                Console.WriteLine("2. Add new customer");
                Console.WriteLine("3. Delete customer");
                Console.WriteLine("4. Update customer");
                Console.WriteLine("5. exit");
                Console.Write("Enter your choice: ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bank.DisplayCustomers();
                        break;
                    case 2:
                        Console.Write("Enter customer name: ");
                        string name = Console.ReadLine();
                        Console.Write("Enter initial balance: ");
                        double balance = Convert.ToDouble(Console.ReadLine());
                        bank.AddCustomer(name, balance);
                        break;
                    case 3:
                        Console.WriteLine("Enter customer ID to delete: ");
                        int deleteId = Convert.ToInt32(Console.ReadLine());
                        bank.DeleteCustomer(deleteId);
                        break;
                    case 4:
                        Console.Write("Enter customer ID to update: ");
                        int updateId = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter new customer name: ");
                        string newName = Console.ReadLine();
                        Console.Write("Enter new balance: ");
                        double newBalance = Convert.ToDouble(Console.ReadLine());
                        bank.UpdateCustomer(updateId, newName, newBalance);
                        break;
                    case 5:
                        Console.WriteLine("Exiting...");
                        break;
                    default:
                        Console.WriteLine("Invalid choice, please try again");
                        break;
                }
            } while (choice != 5);
        }
    }
}