namespace utility;

public static class Util
{
    public static string ToJoin(this string value)
    {
        return string.Join('-', value);
    }
}
