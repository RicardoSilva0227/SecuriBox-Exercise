namespace SecuriboxExercise
{
    public abstract class TransactionDefault
    {
        //since this is for testing purposes, I will keep the last ID here.
        private static int lastTransactionId = 0;

        public int TransactionsId { get; }
        public int ProductId { get; }
        public string ProductName { get; }
        public decimal UnitaryPriceWithoutTax { get; }
        public int Quantity { get; }
        public decimal TaxRate { get; }

        // Base Constructor
        public TransactionDefault(int productId, string productName, decimal unitaryPriceWithoutTax, int quantity, decimal taxRate)
        {
            TransactionsId = ++lastTransactionId;
            ProductId = productId;
            ProductName = productName;
            UnitaryPriceWithoutTax = unitaryPriceWithoutTax;
            Quantity = quantity;
            TaxRate = taxRate;
        }

    }

}

