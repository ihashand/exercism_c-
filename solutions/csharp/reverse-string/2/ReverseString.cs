public static class ReverseString
{
    public static string Reverse(string input)
    {
        var arrayChar = input.ToCharArray();
        Array.Reverse(arrayChar);
        return new String(arrayChar);
    }
}