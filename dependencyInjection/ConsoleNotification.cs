using System;

namespace DependencyInjection{
    internal class ConsoleNotification : INotificationservice
    {
        public void NotifyUsernameChanged(UserD userD)
        {
            Console.WriteLine($"Username has been changed to: {userD.Username}");
        }
    }
}