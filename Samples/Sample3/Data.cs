using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    public class Data
    {
        public List<User> GetUsers()
        {
            return new List<User> { new User { NombreDeUsuario= "Chente",Pasword="vbnm",NombreCompleto="Vicente Eduardo Martinez Morales",Edad=21 } };

        }
    }
}
