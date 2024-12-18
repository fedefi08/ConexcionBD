using ConexcionaBdpyme.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConexcionaBdpyme
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Articulos articulosbd = new Articulos();

            var articulos = articulosbd.Get();

            foreach (var arti in articulos)
            {
                Console.WriteLine(arti.IdArticulo + "              " + arti.Nombre);
            }

            Console.ReadKey();
        }
    }
}
