namespace utility;

public static class Util
{
    public static string ToJoin(this string value)
    {
        return string.Join('-', value);
    }

    public static string DateToString(this DateTime value)
    {
        return value.ToString("yyyy-dd-MM");
    }
}
