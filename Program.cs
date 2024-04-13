using SecuriboxExercise;

// Creating products, Persons and company.
Products product1 = new Products(123, "Laptop", 1000, 0.23m);
Products product2 = new Products(456, "Phone", 500, 0.23m);

Person person = new Person("Ricardo", "testPersonalMail@gmail.com", 123456789);
Person person2 = new Person("Rafaela", "testPersonalMail2@gmail.com", 998877654);
Company company = new Company("testCompany", "testCompany@gmail.com", 987654321);

// Creating the transactions (both purchases and sales accordingly)
Transactions purchase = new Transactions(product1.Id, product1.Name, product1.UnitPrice, 2, product1.TaxRate, company);
Transactions purchase2 = new Transactions(product2.Id, product2.Name, product2.UnitPrice, 3, product2.TaxRate, company);
person.addPurchase(purchase);
person2.addPurchase(purchase2);

Transactions sale = new Transactions(product1.Id, product1.Name, product1.UnitPrice, 2, product1.TaxRate, person);
Transactions sale2 = new Transactions(product2.Id, product2.Name, product2.UnitPrice, 3, product2.TaxRate, person2);
company.AddSale(sale);
company.AddSale(sale2);

int companyNipc = (company.GetIdentificationNumber() != null) ? company.GetIdentificationNumber() : 000000000;

//writting everything to the console
Console.WriteLine("---- Person 1 Purchases ----");
foreach (var p in person.GetPurchases())
{
    Console.WriteLine($"Product: {p.ProductId}, Transaction: {p.TransactionsId}, Quantity: {p.Quantity}, Total Price: {p.UnitaryPriceWithoutTax * p.Quantity * (1 + p.TaxRate)}, Company: {companyNipc}");
}

Console.WriteLine("\n---- Person 2 Purchases ----");
foreach (var p2 in person2.GetPurchases())
{
    Console.WriteLine($"Product: {p2.ProductId}, Transaction: {p2.TransactionsId}, Quantity: {p2.Quantity}, Total Price: {p2.UnitaryPriceWithoutTax * p2.Quantity * (1 + p2.TaxRate)}, Company: {companyNipc}");
}

Console.WriteLine("\n---- Company's Sales ----");
foreach (var s in company.GetSales())
{
    int PersonNif = (s.Person.GetIdentificationNumber() != null) ? s.Person.GetIdentificationNumber() : 000000000;
    Console.WriteLine($"Product: {s.ProductId}, Transaction: {s.TransactionsId}, Quantity: {s.Quantity}, Total Price: {s.UnitaryPriceWithoutTax * s.Quantity * (1 + s.TaxRate)}, Customer: {PersonNif}");
}