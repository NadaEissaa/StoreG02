﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Intefaces
{
    public interface INotificationService
    {
        void SendNotification(string recipient, string message);


    }
}
