using System;
using System.Collections.Generic;
using System.Text;

namespace RefactoringLab.Part01.src
{
    public class LoggerChannel : NotificationChannel
    {
        public override void Send(string to, string message) =>
       Console.WriteLine($"[log] {to}: {message}");
    }
}
