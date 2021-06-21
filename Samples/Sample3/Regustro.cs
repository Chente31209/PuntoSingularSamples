using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sample3
{
    public class Regustro
    {
        Data _data;
        public  Regustro(Data data)
        {
            this._data = data;

        }
        public void Registar()
        {
            string NombreDeUsario, Pasword, NombreCompleto;
            int Edad;
            var Users = this._data.GetUsers();
            Console.WriteLine("Introduce Un Nombre De Usario Unico ");
            NombreDeUsario = Console.ReadLine();
            if (Users.Where(X=>X.NombreDeUsuario== NombreDeUsario).Any())
            {
                Console.WriteLine("Ya Existe");
              
            }
            else
            {
                Console.WriteLine("Introduce Un Pasword");
                Pasword= Console.ReadLine();
                Console.WriteLine("Introduce El Nombre Completo ");
                NombreCompleto= Console.ReadLine();
                Console.WriteLine("Introduce La Edad");
                Edad = int.Parse(Console.ReadLine());
                Users.Add(new User { NombreDeUsuario = NombreDeUsario, NombreCompleto = NombreCompleto, Pasword = Pasword, Edad = Edad });
            }
        }
    }
}
