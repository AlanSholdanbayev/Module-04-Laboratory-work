using System;

public interface INotificationService
{
    void Send(string message);
}

public class EmailService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Отправка Email: {message}");
    }
}

public class SmsService : INotificationService
{
    public void Send(string message)
    {
        Console.WriteLine($"Отправка SMS: {message}");
    }
}

public class Notification
{
    private readonly INotificationService _notificationService;
    
    public Notification(INotificationService notificationService)
    {
        _notificationService = notificationService;
    }

    public void Send(string message)
    {
        _notificationService.Send(message);
    }
}

class Program
{
    static void Main(string[] args)
    {
        INotificationService emailService = new EmailService();
        Notification notification1 = new Notification(emailService);
        notification1.Send("Ваш заказ подтвержден.");
        
        INotificationService smsService = new SmsService();
        Notification notification2 = new Notification(smsService);
        notification2.Send("Ваш заказ отправлен.");
    }
}