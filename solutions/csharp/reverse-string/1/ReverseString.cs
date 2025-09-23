public static class ReverseString
{
    public static string Reverse(string input)
    {
        string revInput = "";
        
        for (int i = input.Length - 1; i >= 0; i--)
        {
            revInput = revInput + input[i];
        }
        
        return revInput;
    }
}