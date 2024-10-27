using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public class User
    {
        public string UserName { get; set; }

        public User(string _userName)
        {
            UserName = _userName;
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
