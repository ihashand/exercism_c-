static class LogLine
{
    public static string Message(string logLine)
    {
        // znajdź pozycję pierwszego dwukropka
        int colonIndex = logLine.IndexOf(':');
        
        // wytnij wszystko po nim
        string messagePart = logLine.Substring(colonIndex + 1);
        
        // usuń spacje, \n, \r z początku/końca
        return messagePart.Trim();
        throw new NotImplementedException("Please implement the (static) LogLine.Message() method");
    }

    public static string LogLevel(string logLine)
    {
        int firstIndex = logLine.IndexOf("[");
        int lastIndex = logLine.LastIndexOf("]");

        string messagePart = logLine.Substring(firstIndex + 1, lastIndex - 1);
        return messagePart.ToLower();
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        //Pobieramy indeksy dla [  oraz ]
        int firstIndex = logLine.IndexOf("[");
        int lastIndex = logLine.IndexOf("]");

        //Wycinamy wiadomość która w nich jest
        string levelMessage = logLine.Substring(firstIndex + 1, lastIndex - 1).ToLower();

        //Wiadomosć bez levelMessage oraz []
        string returnMessage = logLine.Remove(0, logLine.IndexOf(":") + 1);
        
        //Usuwamy znaki specjalne i trimujemy
        returnMessage = returnMessage.Replace('\r',' ').Replace('\n',' ').Replace('\t',' ').Trim(); 

        //Dodajemy wiadomosc na koncu:
        return returnMessage + " (" + levelMessage + ")";
        
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
