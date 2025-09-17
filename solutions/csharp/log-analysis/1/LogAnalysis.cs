public static class LogAnalysis 
{
        
    public static string SubstringAfter(this string input, string delimiter)
    {
        int index = input.IndexOf(delimiter);
        int length = delimiter.Length;
        string returnMessage = input.Substring(index + length);
        return returnMessage;

        throw new System.NotImplementedException();
    }

 
    public static string SubstringBetween(this string input, string firstString, string secondString)
    {
        int firstStringLength = firstString.Length;
        int secondStringLength = secondString.Length;
        
        int firstIndex = input.IndexOf(firstString);
        string message = input.Substring(firstIndex + firstStringLength);
        
       
        int secondIndex = message.IndexOf(secondString);

        message = message.Substring(0, secondIndex);
        
        return message;
        throw new System.NotImplementedException();
    }

    public static string Message(this string logLine)
    {
        int index = logLine.IndexOf(":");
        string message = logLine.Substring(index+1);
        return message.Trim();
        
        throw new System.NotImplementedException();
    }

    public static string LogLevel(this string logLine)
    {
        int firstIndex = logLine.IndexOf("[");
        int secondIndex = logLine.IndexOf("]");
        string message = logLine.Substring(firstIndex + 1, secondIndex - 1);
        return message.Trim();
        throw new System.NotImplementedException();
    }
}  