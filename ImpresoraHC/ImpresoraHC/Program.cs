using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresoraHC
{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("**EMPRESA DE IMPRESORAS**");
            Console.WriteLine();
            Impresora impresora2000 = new ImpresoraModelo2000();
            Impresora impresora2001 = new ImpresoraModelo2001();

            impresora2000.Imprimir();

            impresora2001.Fotocopiar();
            impresora2001.Imprimir();

            Console.ReadKey();
        }
    }
}
