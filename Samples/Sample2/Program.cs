using System;
using System.Collections.Generic;
using System.Linq;

namespace Sample2
{
    class Program
    {
        static void Main(string[] args)
        {
            string Pin4;
            bool Detener = true;
            while (Detener)
            {
                Console.Write("Dame Un Pin Numerico de Cuaro Dijitos >>>");
                 Pin4= Console.ReadLine();
                Detener = Comprobar(Pin4);
                if (Detener == false)
                {
                    Console.WriteLine(Adibinar(Pin4));
                }
            }
            
            
        }
        public static string Adibinar(string Item)
        {
            var random = new Random();
            List<string> Pines = new List<string> { };
            for (int i = 0; i < 1000; i++)
            {
                Pines.Add($"{random.Next(0,9)}{random.Next(0, 9)}{random.Next(0, 9)}{random.Next(0, 9)}");
            }
            if (Pines.Where(X=>X==Item).Any())
            {
                return $"Se Adibino es {Item}";
            }
            else
            {
                return $"No Le Puedo Enotar Entre 1000 pocibilidades";
            }
        }
        public static bool Comprobar(string Pin)
        {
            int Prueba = 0;
            for (int i=0; i < Pin.Length; i++)
            {
                if(Pin[i] >= 65 && Pin[i] <= 122)
                {
                    break;
                }
                else
                {
                    Prueba++;
                }
            }
            if (Prueba == 4)
            {
                return false;
            }
            else
            {
                return false;
            }
        }
    }
}
