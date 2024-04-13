namespace SecuriboxExercise
{
    public class Transactions : TransactionDefault
    {
        public Company? Company { get; }
        public Person? Person { get; }

        // Constructor for purchase made by a person
        public Transactions(int productId, string productName, decimal unitaryPriceWithoutTax, int quantity, decimal taxRate, Person person) 
        : base(productId, productName, unitaryPriceWithoutTax, quantity, taxRate)
        {
            Person = person;
        }

        // Constructor for sale made by a company
        public Transactions(int productId, string productName, decimal unitaryPriceWithoutTax, int quantity, decimal taxRate, Company company)
        : base(productId, productName, unitaryPriceWithoutTax, quantity, taxRate)
        {
            Company = company;
        }
    }
}





