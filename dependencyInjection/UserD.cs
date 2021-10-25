using System;


namespace DependencyInjection
{
    internal class UserD
    {
        #region Variables
        //private ConsoleNotification _notificationService; //underscore convention: private variable in a public class
        private INotificationservice _notificationService; //Gets rid of direct dependency on ConsoleNotification class. Must also change constructor.
        #endregion


        #region Properties
        public string Username {get; private set;}
        #endregion
        

        #region Constructors
        public UserD(string username, INotificationservice notificationService)
        {
            Username = username;
            //_notificationService = new ConsoleNotification();
            _notificationService = notificationService;
        }
        #endregion


        #region Methods
        public void ChangeUsername(string newUsername)
        {
            Username = newUsername;
            _notificationService.NotifyUsernameChanged(this);
        }
        #endregion
    }
}