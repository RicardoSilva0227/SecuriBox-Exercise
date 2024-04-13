namespace SecuriboxExercise
{
    public class Company
    {
        public string Name { get; }
        public string Email { get; set; }
        private int Nipc;
        private List<Transactions> sales = new List<Transactions>();

        public int GetIdentificationNumber()
        {
            return Nipc;
        }

        public Company(string name, string email, int nipc)
        {
            Name = name;
            Email = email;
            Nipc = nipc;
        }

        public void AddSale(Transactions transaction)
        {
            sales.Add(transaction);
        }

        public IReadOnlyList<Transactions> GetSales()
        {
            return sales.AsReadOnly();
        }
    }
}