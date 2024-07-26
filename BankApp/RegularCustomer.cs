namespace BankApp
{
    // Pewarisan dari kelas customer
    public class RegularCustomer : Customer
    {
        // Konstruktor
        public RegularCustomer(int id, string name, double balance) : base(id, name, balance)
        {
        }

        // Override metode virtual (polymorphism)
            public override void DisplayInfo()
            {
                Console.WriteLine($"\n[Regular Customer]\n ID: {Id}\n Name: {Name}\n Balance: {Balance:C}");
            }
    }
}