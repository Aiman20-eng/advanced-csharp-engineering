public static class StringExtensions
{
    public static bool IsValidCustomerName(this string value)
    {
        return !string.IsNullOrWhiteSpace(value);
    }
}