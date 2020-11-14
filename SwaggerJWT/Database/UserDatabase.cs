using SwaggerJWT.Models;
using System.Collections.Generic;
using System.Linq;

namespace SwaggerJWT.Database
{
    public class UserDatabase
    {
        public static User Get(string username, string password)
        {
            username ??= "";
            password ??= "";

            List<User> users = new List<User>();
            users.Add(new User { Login = "Diogo", Password = "Carreira" });
            return users.Where(x => x.Login.ToLower() == username.ToLower() && x.Password == password).FirstOrDefault();
        }
    }
}
