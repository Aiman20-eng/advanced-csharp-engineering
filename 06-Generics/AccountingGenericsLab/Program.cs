using AccountingGenericsLab.Models;
using AccountingGenericsLab.Repositories;

Console.WriteLine("=== Accounting Generics Lab ===");
Console.WriteLine();

Repository<Invoice> invoiceRepository = new();

invoiceRepository.Add(
    new Invoice
    {
        Id = 1,
        CustomerName = "Customer A",
        Amount = 15_000
    });

invoiceRepository.Add(
    new Invoice
    {
        Id = 2,
        CustomerName = "Customer B",
        Amount = 25_000
    });

Console.WriteLine("INVOICES");

foreach (var invoice in invoiceRepository.GetAll())
{
    Console.WriteLine(
        $"Invoice #{invoice.Id} | " +
        $"Customer: {invoice.CustomerName} | " +
        $"Amount: {invoice.Amount:N2}");
}

Console.WriteLine();

Repository<Payment> paymentRepository = new();

paymentRepository.Add(
    new Payment
    {
        Id = 1,
        CustomerName = "Customer A",
        Amount = 10_000
    });

paymentRepository.Add(
    new Payment
    {
        Id = 2,
        CustomerName = "Customer B",
        Amount = 5_000
    });

Console.WriteLine("PAYMENTS");

foreach (var payment in paymentRepository.GetAll())
{
    Console.WriteLine(
        $"Payment #{payment.Id} | " +
        $"Customer: {payment.CustomerName} | " +
        $"Amount: {payment.Amount:N2}");
}

Console.WriteLine();

Repository<Expense> expenseRepository = new();

expenseRepository.Add(
    new Expense
    {
        Id = 1,
        Description = "Office Rent",
        Amount = 50_000
    });

expenseRepository.Add(
    new Expense
    {
        Id = 2,
        Description = "Internet",
        Amount = 5_000
    });

Console.WriteLine("EXPENSES");

foreach (var expense in expenseRepository.GetAll())
{
    Console.WriteLine(
        $"Expense #{expense.Id} | " +
        $"Description: {expense.Description} | " +
        $"Amount: {expense.Amount:N2}");
}

Console.WriteLine();

Invoice? foundInvoice = invoiceRepository.GetById(2);

if (foundInvoice is not null)
{
    Console.WriteLine(
        $"Found Invoice #{foundInvoice.Id} " +
        $"with amount {foundInvoice.Amount:N2}");
}

Console.WriteLine();

Console.WriteLine(
    $"Invoice count: {invoiceRepository.Count()}");

Console.WriteLine(
    $"Payment count: {paymentRepository.Count()}");

Console.WriteLine(
    $"Expense count: {expenseRepository.Count()}");