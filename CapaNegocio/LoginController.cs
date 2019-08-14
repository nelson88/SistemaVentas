using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDatos;
namespace CapaNegocio
{
    public class LoginController
    {
        LoginDataAccess data = new LoginDataAccess();
        public bool LoginValidation(string user, string pass)
        {
            return data.LoginValidate(user, pass);
        }
    }
}
