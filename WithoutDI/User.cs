using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithoutDI
{
    public class User
    {
        private ConsoleNotification _notificationService;
        public string UserName { get; set; }

        public User(string userName)
        {
            UserName = userName;

            // Här är vi hård kopplad till en concretion! BAD!
            _notificationService= new ConsoleNotification();
        }

        public void ChangeUserName(string newUserName)
        {
            UserName= newUserName;
            _notificationService.NotifiyUserNameChanged(this);
        }
    }
}
