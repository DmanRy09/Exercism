public static class LogAnalysis 
{
    public static string SubstringAfter(this string str, string delimiter)
    {
        int delimiterIndex = str.IndexOf(delimiter);
        if (delimiterIndex == -1)
            return str;
        
        return str.Substring(delimiterIndex + delimiter.Length);
    }

    public static string SubstringBetween(this string str, string startDelimiter, string endDelimiter)
    {
        int startIndex = str.IndexOf(startDelimiter) + startDelimiter.Length;
        int endIndex = str.IndexOf(endDelimiter, startIndex);
        
        if (startIndex - startDelimiter.Length == -1 || endIndex == -1)
            return string.Empty;
        
        return str.Substring(startIndex, endIndex - startIndex);
    }

    public static string Message(this string str)
    {
        return str.SubstringAfter(": ");
    }

    public static string LogLevel(this string str)
    {
        return str.SubstringBetween("[", "]");
    }
}