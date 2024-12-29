using System.Security.Cryptography.X509Certificates;

public class Logger
{
    public void Log(Exception ex)
    {
        File.AppendAllText("log.txt", $"[{DateTime.Now}], Exception Message: {ex.Message}, Stack trace: {ex.StackTrace}\n\n");
    }
}