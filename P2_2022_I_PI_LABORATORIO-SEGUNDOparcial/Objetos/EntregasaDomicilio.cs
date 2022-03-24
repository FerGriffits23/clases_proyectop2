using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P2_2022_I_PI_LABORATORIO_SEGUNDOparcial.Objetos
{
    internal class EntregasaDomicilio
    {
        public string NombreCliente { get;  }
        public string NumeroTelefono { get;  }
        public string Direccion { get;  }
        public string Tipocomida { get; set; }
        public string Fecha { get; set; }
        public decimal PrecioTotal { get; set; }
        public int TiempodeEntrega { get; set; }
        private int tiempoEntrega;

        public EntregasaDomicilio(string pNombreCliente, string pNumeroTelefono, string pDireccion, string pTipocomida, 
            string pFecha, decimal pPrecioTotal, int pTiempodeEntrega)
        {
            NombreCliente        = pNombreCliente;
            NumeroTelefono       = pNumeroTelefono;
            Direccion            = pDireccion;
            Tipocomida           = pTipocomida;
            Fecha                = pFecha;
            PrecioTotal          = pPrecioTotal;
            TiempodeEntrega      =pTiempodeEntrega;   
        }

        public int TiempoEntrega
        {
            get { return tiempoEntrega; }

            set 
            {
                if (value < 30) 
                {
                    WriteLine("EL tiempo se  paso  de lo  estimado\n");
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(tiempoEntrega)} Deberia de ser > a30");
                }
                
                tiempoEntrega = value; }
        }

        public override string ToString() => 
            $"Nombre:{NombreCliente}\n"+
            $"NumeroTelefono:{NumeroTelefono}\n" +
            $"PrecioTota:{PrecioTotal}\n " +
            $"TipoCOmida:{Tipocomida}\n" +
            $"Fecha:{Fecha}\n"+
            $"Su Direccio es:{Direccion}\n"+
            $"Tiempoentrega:{TiempodeEntrega}\n";
        


    }
}
