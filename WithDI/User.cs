using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public class User
    {
        INotificationService _notificationService;
        public string UserName { get; set; }

        public User(string userName, INotificationService notificationService)
        {
            _notificationService = notificationService;
            UserName = userName;
        }
        public void ChangeUserName(string newUserName)
        {
            UserName = newUserName;
            _notificationService.NotifiyUserNameChanged(this);
        }

        //private INotificationService _notificationService;
        //public string UserName { get; set; }

        //public User(string userName, INotificationService notificationService)
        //{
        //    UserName = userName;

        //    // LOOSELY COUPLED till en Interface! :)
        //    _notificationService = notificationService;
        //}

        //public void ChangeUserName(string newUserName)
        //{
        //    UserName = newUserName;
        //    _notificationService.NotifiyUserNameChanged(this);
    }
}
