using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RandomUser.model;

namespace KKB.BLL.model
{
    public class ServiceUser
    {
        public bool LogOn(User user, out string message)
        {
            if(user.login == "admin"&&user.password.Equals("admin"))
            {
                results results = GenerateUser.GetUser();
                user.fullname = string.Format("{0} {1} {2}",
                    results.name.title,
                    results.name.first,
                    results.name.last);
                message = "OK";
                return true;
            }

            else
            {
                message = "Неправильный логин или пароль";
                return false;
            }
        }
    }
}
