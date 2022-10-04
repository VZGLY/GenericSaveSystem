using Delegate;
using MyLib;

User user = new User(){Name = "jean-Phi"};

SaveManager.Save(user);

user = new User();


user = SaveManager.Load<User>();

Console.WriteLine(user.Name);

Console.ReadKey();







