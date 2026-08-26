namespace AccountingGenericsLab.Models;

public class Payment : IEntity
{
    public int Id { get; set; }

    public string CustomerName { get; set; } = string.Empty;

    public decimal Amount { get; set; }
}