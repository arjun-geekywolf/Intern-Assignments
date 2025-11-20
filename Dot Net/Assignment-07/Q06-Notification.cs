using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_07
{
   public interface INotificationService
    {
        void Notify(string message);

    }


    public class SMSNotifier : INotificationService
    {
        public void Notify(string message)
        {
            Console.WriteLine($"SMS: {message}");
        }
    }

    public class EmailNotifier : INotificationService {

        public void Notify(string message) {
            Console.WriteLine($"Email: {message}");
        }
    }

    public class PushNotification : INotificationService {

        public void Notify(string message) {

            Console.WriteLine($"PushNotification: {message}");
        }
    }

    public class AppointmentService
    {
        private readonly INotificationService NotificationService;
        public AppointmentService(INotificationService service)
        {
            NotificationService = service;
        }

        public void Send(string message)
        {
            NotificationService.Notify(message);
        }

    }

}
