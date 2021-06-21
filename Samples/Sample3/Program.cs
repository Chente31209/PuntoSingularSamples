using System;

namespace Sample3
{
    class Program
    {
        static void Main(string[] args)
        {
            int Opciones;
            Data data = new Data();
            Login login = new Login(data);
            Regustro regustro = new Regustro(data);
            Console.WriteLine("0; Niguno \n 1; Login \n 2; Reguistar");
            Opciones = int.Parse(Console.ReadLine());
            while (Opciones != 0)
            {
                if (Opciones == 1)
                {
                    login.Logerse();
                    Console.WriteLine("0; Niguno \n 1; Login \n 2; Reguistar");
                    Opciones = int.Parse(Console.ReadLine());
                }
                    
                if (Opciones == 2)
                { 
                    regustro.Registar();
                    Console.WriteLine("0; Niguno \n 1; Login \n 2; Reguistar");
                    Console.WriteLine($"{data.GetUsers().Count}");
                    Opciones = int.Parse(Console.ReadLine());
                }

                else
                {
                    Console.WriteLine("0; Niguno \n 1; Login \n 2; Reguistar");
                    Opciones = int.Parse(Console.ReadLine());
                }
                    

            }
        }
    }
}
