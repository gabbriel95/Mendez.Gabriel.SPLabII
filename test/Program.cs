using Entidades;
using System;

using System.Collections.Generic;

namespace test
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Utiles> utiles = new List<Utiles>();

            Goma goma = new Goma(1, "asd", 23, Goma.eTamanio.Mediana, 1);
            Lapiz lapiz = new Lapiz(2, "asd", 23, Lapiz.eColor.Rojo, 1);

            utiles.Add(goma);
            utiles.Add(lapiz);


            foreach (Utiles tile in utiles) 
            {

                if (tile.GetType() == typeof(Goma)) 
                {
                   Console.WriteLine("Es una goma");
                }

                if (tile.GetType() == typeof(Lapiz))
                {
                    Console.WriteLine("Es una lapiz");
                }
            }
        }
    }
}
