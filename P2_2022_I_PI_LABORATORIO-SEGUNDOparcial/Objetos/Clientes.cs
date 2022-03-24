using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P2_2022_I_PI_LABORATORIO_SEGUNDOparcial.Objetos
{
    internal class Clientes
    {
       public string Nombre { get;}
        public string Apellido { get;}
        public string Id { get;}
        public string NumeroTelefono { get;}
        public string RTN { get;}
        public string TarjetaoEfectivo { get; set; }
        public string LLeveroComerRestaurante { get; set; }
        private decimal facturaTotal;

        public Clientes (string pNombre, string pApellido , string pId, string pNumeroTelefono, 
            string pRTN, string pTarjetaOfectivo, string pLlevaroComerRestaurante, decimal pFacturaTotal)
        { 
            Nombre                      = pNombre;
            Apellido                    = pApellido;
            Id                          = pId;
            NumeroTelefono              = pNumeroTelefono;
            RTN                         = pRTN;
            TarjetaoEfectivo            = pTarjetaOfectivo;
            LLeveroComerRestaurante     = pLlevaroComerRestaurante;
        }
        public decimal FacturaTotal
        {
            get { return facturaTotal; }
            set
            {

                if (value < 0)
                {
                    WriteLine("DEBE DE SER MAYOY A CERO SU FACTURA");
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(facturaTotal)} deberia ser > 0 el pago");
                }
                if (value > 1)
                {
                    WriteLine("EXITOSO");
                    throw new ArgumentOutOfRangeException(
                        nameof(value), value, $"{nameof(facturaTotal)} deberia ser > 0 el pago");
                }
                facturaTotal = value;
            }

        }
        public override string ToString() =>
            $"Nombre es:{Nombre}\n" +
            $"Numero de Apellido:{Apellido}\n" +
            $"Numero de Telefeno{NumeroTelefono}\n"+
            $"Su id es:{Id}\n" +
            $"Para comer aqui o para llevar:{LLeveroComerRestaurante}\n" +
            $"RTN:{RTN}\n" +
            $"paga con Tarjeta o Efetivo:{TarjetaoEfectivo}\n";

    }
}
