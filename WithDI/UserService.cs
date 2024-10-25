using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    internal class UserService
    {
        private INotificationService _notificationService;

        public UserService(INotificationService notificationService)
        {
            // LOOSELY COUPLED till en Interface! :)
            _notificationService = notificationService;
        }

        public void ChangeUserName(User user, string newUserName)
        {
            user.UserName = newUserName;
            _notificationService.NotifiyUserNameChanged(user);
        }

    }
}
