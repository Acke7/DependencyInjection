using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WithDI
{
    public class ConsoleNotification : INotificationService
    {
        public void NotifiyUserNameChanged(User user)
        {
            Console.WriteLine($"User name changed to: {user.UserName}");
        }
    }

}
