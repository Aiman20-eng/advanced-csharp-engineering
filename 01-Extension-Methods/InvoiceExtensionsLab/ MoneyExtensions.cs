public static class MoneyExtensions
{
    public static bool IsLargeAmount(this decimal amount)
    {
        return amount >= 10_000;
    }
}