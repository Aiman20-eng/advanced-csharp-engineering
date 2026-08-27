using AccountingLinqLab.Models;

namespace AccountingLinqLab.Data;

public static class AccountingData
{
    public static List<Customer> Customers { get; } =
    [
        new Customer
        {
            Id = 1,
            Name = "Ahmed",
            City = "Sana'a"
        },

        new Customer
        {
            Id = 2,
            Name = "Mohammed",
            City = "Aden"
        },

        new Customer
        {
            Id = 3,
            Name = "Ali",
            City = "Taiz"
        }
    ];

    public static List<Invoice> Invoices { get; } =
    [
        new Invoice
        {
            Id = 1001,
            CustomerId = 1,
            Amount = 5_000m,
            IsPaid = true,
            IssueDate = new DateTime(2026, 1, 10)
        },

        new Invoice
        {
            Id = 1002,
            CustomerId = 2,
            Amount = 25_000m,
            IsPaid = false,
            IssueDate = new DateTime(2026, 1, 12)
        },

        new Invoice
        {
            Id = 1003,
            CustomerId = 1,
            Amount = 15_000m,
            IsPaid = false,
            IssueDate = new DateTime(2026, 1, 15)
        },

        new Invoice
        {
            Id = 1004,
            CustomerId = 3,
            Amount = 50_000m,
            IsPaid = true,
            IssueDate = new DateTime(2026, 1, 18)
        },

        new Invoice
        {
            Id = 1005,
            CustomerId = 2,
            Amount = 8_000m,
            IsPaid = false,
            IssueDate = new DateTime(2026, 1, 20)
        }
    ];

    static AccountingData()
    {
        foreach (var invoice in Invoices)
        {
            var customer = Customers.FirstOrDefault(
                customer => customer.Id == invoice.CustomerId);

            if (customer is not null)
            {
                customer.Invoices.Add(invoice);
            }
        }
    }
}