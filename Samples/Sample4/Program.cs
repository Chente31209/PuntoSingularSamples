using System;

namespace Sample4
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] str = { };
            Identificar(str);
        }
        public static void Identificar(object Item)
        {
            Console.WriteLine(Item.GetType().ToString());
                
            if (Item.GetType().ToString() == "System.String")
            {
                Console.WriteLine("Eres Un String");
            }
            if (Item.GetType().ToString() == "System.Int32")
            {
                Console.WriteLine("Eres Un Int");

            }
            if (Item.GetType().ToString() == "System.String[]")
            {
                Console.WriteLine("Eres Un Lista");

            }
            else
            {
                Console.WriteLine("Eres de otro tipo");

            }
        }
    }
}
