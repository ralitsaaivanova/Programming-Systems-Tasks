using Welcome.Model;

namespace Welcome.ViewModel
{
    public class UserViewModel
    {
        private User _user; 

        public UserViewModel(User user)
        {
            _user = user;
        }

        public string Password
        {
            get { return _user.Password; }
            set { _user.Password = value; }
        }

        public string Names
        {
            get { return _user.Names; }
            set { _user.Names = value; }
        }
    }
}
