using System;

static class LogLine
{
    public static string Message(string logLine)
    {
       return logLine.Substring(logLine.IndexOf(":") + 1).Trim().ToString();
    }

    public static string LogLevel(string logLine)
    {
       return logLine.Substring(logLine.IndexOf('[') +1 , logLine.IndexOf(']')+ -1).ToLower();
    }

    public static string Reformat(string logLine)
    {
        var level = logLine.Substring(0, logLine.IndexOf(':')-1);
        var message = logLine.Substring(logLine.IndexOf(':') +1);
        return message + $"({level})".ToLower();
    }
}
