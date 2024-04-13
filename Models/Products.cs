namespace SecuriboxExercise
{
    public class Products
    {
        public int Id { get; }
        public string Name { get; }
        public decimal UnitPrice { get; }
        public decimal TaxRate { get; }

        public Products(int identification, string name, decimal unitPrice, decimal taxRate)
        {
            Id = identification;
            Name = name;
            UnitPrice = unitPrice;
            TaxRate = taxRate;
        }
    }
}