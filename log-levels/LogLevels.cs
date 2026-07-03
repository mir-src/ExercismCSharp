static class LogLine
{
    public static string Message(string logLine)
    {
        logLine = System.Text.RegularExpressions.Regex.Replace(logLine, @"\[.*\]: ", "");
        logLine = logLine.Trim();
        return logLine;
    }

    public static string LogLevel(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.LogLevel() method");
    }

    public static string Reformat(string logLine)
    {
        throw new NotImplementedException("Please implement the (static) LogLine.Reformat() method");
    }
}
