using Autofac;
using WithDI;

ContainerBuilder myContainerBuilder = new ContainerBuilder();


myContainerBuilder.RegisterType<UserService>().AsSelf();

var myContainer = myContainerBuilder.Build();

var notificationService = myContainer.Resolve<INotificationService>();

var userService = myContainer.Resolve<UserService>();



//var notificationService = new ConsoleNotification();

var user1 = new User("Richard");

userService.ChangeUserName(user1, "Ahmad");

Console.ReadLine();


