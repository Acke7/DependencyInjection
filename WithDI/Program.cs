using Autofac;
using WithDI;

ContainerBuilder myContainerBuilder = new ContainerBuilder();


myContainerBuilder.RegisterType<UserService>().AsSelf();

var myContainer = myContainerBuilder.Build();

var notificationService = myContainer.Resolve<INotificationService>();





//var notificationService = new ConsoleNotification();

var user1 = new User("Richard", notificationService);

user1.ChangeUserName("Richard the Lionheart (With DI)");

Console.ReadLine();


