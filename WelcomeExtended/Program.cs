using Welcome.Model;
using Welcome.Others;
using Welcome.View;
using Welcome.ViewModel;
using WelcomeExtended.Data;
using WelcomeExtended.Helpers;
using static WelcomeExtended.Others.Delegates;

namespace WelcomeExtended
{
     class Program
    {
        static void Main(string[] args)
        {
                /*
                var user = new User()
                {
                    Names = "John Smith",
                    Password = "password123",
                    Role = UserRolesEnum.STUDENT
                };

                var viewModel = new UserViewModel(user);
                var view = new UserView(viewModel);
                view.Display();
                view.DisplayError();
                */

                UserData userData = new UserData();

                User studentUser = new User()
                {
                    Names = "student",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT

                };

                User studentUser2 = new User()
                {
                    Names = "student2",
                    Password = "123",
                    Role = UserRolesEnum.STUDENT

                };

                User teacherUser = new User()
                {
                    Names = "Teacher",
                    Password = "1234",
                    Role = UserRolesEnum.PROFESSOR
                };

                User adminUser = new User()
                {
                    Names = "Administrator",
                    Password = "12345",
                    Role = UserRolesEnum.ADMIN

                };

                userData.AddUser(studentUser);
                userData.AddUser(studentUser2);
                userData.AddUser(teacherUser);
                userData.AddUser(adminUser);

                Console.WriteLine("Enter user name:");
                string username = Console.ReadLine();

                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();

                if (userData.ValidateCredentials(username, password))
                {
                    User u = userData.GetUser(username, password);
                    Console.WriteLine("User details:");
                    Console.WriteLine(u.ToString());
                }

        }
    }
}
