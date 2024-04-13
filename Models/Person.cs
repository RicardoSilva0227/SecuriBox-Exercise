namespace SecuriboxExercise
{
    public class Person
    {
        public string Name { get; }
        public string Email { get; set; }
        private int Nif;

        private List<Transactions> purchases = new List<Transactions>();

        public int GetIdentificationNumber()
        {
            return Nif;
        }

        public Person(string name, string email, int nif)
        {
            Name = name;
            Email = email;
            Nif = nif;
        }

        public void addPurchase(Transactions transaction)
        {
            purchases.Add(transaction);
        }

        public IReadOnlyList<Transactions> GetPurchases()
        {
            return purchases.AsReadOnly();
        }
    }
}


