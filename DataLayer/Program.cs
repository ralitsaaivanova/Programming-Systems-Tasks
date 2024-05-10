using DataLayer.Database;
using DataLayer.Model;
using Welcome.Others;

namespace DataLayer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using (var context = new DatabaseContext())
            {
                context.Database.EnsureCreated();
                context.Add<DatabaseUser>(new DatabaseUser()
                {
                    Names = "user",
                    Password = "password",
                    Expires = DateTime.Now,
                    Role = UserRolesEnum.STUDENT
                });
                context.SaveChanges();
                var users = context.Users.ToList();
               

                Console.WriteLine("Enter username:");
                string username = Console.ReadLine();
                Console.WriteLine("Enter password:");
                string password = Console.ReadLine();
                bool isValidUser = context.Users.Any(u => u.Names == username && u.Password == password);

                if (isValidUser)
                {
                    Console.WriteLine("Valid user");
                }
                else
                {
                    Console.WriteLine("User not valid");
                }

                Console.ReadKey();

            }
        }
    }
}
