using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImpresoraHC
{
    public class ImpresoraModelo2001 : Impresora,IEscanear,IFotocopias
    {
        public void Escanear()
        {
            throw new NotImplementedException();
        }

        public void Fotocopiar()
        {
            throw new NotImplementedException();
        }

        public override void Imprimir()
        {
            throw new NotImplementedException();
        }

    }
}

