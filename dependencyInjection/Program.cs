// See https://aka.ms/new-console-template for more information
using System;

namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            //Addign below for dependency injection:
            var notificationService = new ConsoleNotification();

            var user1 = new UserD("Tim", notificationService);
            user1.ChangeUsername("Robert");
            user1.ChangeUsername("Ted");

            Console.ReadKey();
        }
    }
}
