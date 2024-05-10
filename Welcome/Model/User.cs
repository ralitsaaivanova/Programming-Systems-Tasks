using Welcome.Others;

namespace Welcome.Model
{
    public class User
    {
        private string names; 
        private string password; 
        private UserRolesEnum role;
        private int id;
        private DateTime expires;
        private string v1;
        private string v2;
        private UserRolesEnum sTUDENT;

        public User(string names, string password, UserRolesEnum role, int id, DateTime expires)
        {
            this.names = names;
            this.password = password;
            this.role = role;
            this.id = id;
            this.expires = expires;   
        }

        public User() { }

        public User(string v1, string v2, UserRolesEnum sTUDENT)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.sTUDENT = sTUDENT;
        }

        public string Names
        {
            get { return names; }
            set { names = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }

        public UserRolesEnum Role
        {
            get { return role; }
            set { role = value; }
        }

        public virtual int Id
        {
            get { return id;}
            set { id = value; }
        }

        public DateTime Expires
        {
            get { return expires;  }
            set { expires = value;  }
        }
    }
}
