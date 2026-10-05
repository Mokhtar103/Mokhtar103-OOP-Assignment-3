namespace RefactoringLab;

public abstract class NotificationChannel
{
    public abstract void Send(string to, string message);
}

public class EmailChannel : NotificationChannel
{
    public override void Send(string to, string message) =>
        Console.WriteLine($"[email] {to}: {message}");
}

public class SmsChannel : NotificationChannel
{
    public override void Send(string to, string message) =>
        Console.WriteLine($"[sms] {to}: {message}");
}
public class Notifier
{
    private readonly NotificationChannel _channel;

    public Notifier(NotificationChannel channel)
    {
        _channel = channel;
    }

    public void Send(string to, string message, DateTime? sendAt = null, bool isUrgent = false)
    {

        string finalMessage = isUrgent ? $"[URGENT] {message}" : message;

        if (sendAt.HasValue)
        {
            string channelPrefix = _channel is EmailChannel ? "email" : "sms";
            Console.WriteLine($"[{channelPrefix} scheduled {sendAt.Value:g}] {to}: {finalMessage}");
        }
        else
        {
            _channel.Send(to, finalMessage);
        }
    }
}
