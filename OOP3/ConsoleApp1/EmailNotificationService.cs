using ConsoleApp1.Intefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class EmailNotificationService :INotificationService
    {
        public void SendNotification(string recipient , string message)
        {
            Console.WriteLine($"Email sent to {recipient}:{message}");
        }
    }
}
