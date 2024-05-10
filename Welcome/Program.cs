using Welcome.Model;
using Welcome.View;
using Welcome.ViewModel;

namespace Welcome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            User u = new User("Person", "12345", Others.UserRolesEnum.STUDENT);
            UserViewModel uvm = new UserViewModel(u);
            UserView uv = new UserView(uvm);
            uv.Display();
        }
    }
}
