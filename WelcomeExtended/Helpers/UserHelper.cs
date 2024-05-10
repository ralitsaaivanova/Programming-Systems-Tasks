using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Welcome.Model;
using WelcomeExtended.Data;

namespace WelcomeExtended.Helpers
{
    internal static class UserHelper
    {
        public static string ToString(this User user)
        {
           return user.ToString();
        }

        public static bool ValidateCredentials(this UserData userData, string name, string password)
        {
            string emptyField = "";

            if (String.IsNullOrWhiteSpace(name))
            {
                emptyField = "Name";
            }else if(String.IsNullOrWhiteSpace(password)){
                emptyField = "Password";
            }

            if (String.IsNullOrWhiteSpace(emptyField))
            {
                return true;
            }
            else{
                throw new Exception("Field " + emptyField + "cannot be empty!");
                return false;
            }
        }

    }
}
