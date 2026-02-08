public class NotificationService
{
    private readonly INotificationSender sender;

    public NotificationService(INotificationSender sender)
    {
        this.sender = sender;
    }

    public void SendNotification(string message)
    {
        sender.Send(message);
    }
}
