using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    public class Login
    {
        Data _data;
        public  Login(Data data)
        {
            this._data = data;
        }
        public void Logerse()
        {

            string NombreDeUsuario, Pasword;
            
            var Users = this._data.GetUsers();

            Console.WriteLine("Nombre de Usuario");
            NombreDeUsuario = Console.ReadLine();
            Console.WriteLine("Pasword");
            Pasword = Console.ReadLine();
            if (Users.Where(x => x.NombreDeUsuario == NombreDeUsuario).Any())
            {
                if (Users.Where(x => x.Pasword == Pasword).Any())
                    Inicio.Entrar(Users.Where(x => x.NombreDeUsuario == NombreDeUsuario).FirstOrDefault());
            }
            else
                Console.WriteLine("Noexite");


        }
    }
}
