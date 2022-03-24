using P2_2022_I_PI_LABORATORIO_SEGUNDOparcial.Objetos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace P2_2022_I_PI_LABORATORIO_SEGUNDOparcial
{
    internal class Program
    {
        static void Main(string[] args)
        {

            EntregasaDomicilio cliente1 = new EntregasaDomicilio("Fernando", "98035070","Colonia Nueva Suyapa", "Chuleta Con Tajaditas",
                "12-4-2022",150.00m,20);

            try
            {
                WriteLine($"LOS NOMBRE DE El CLIENTE ES {cliente1.NombreCliente}\n");
                WriteLine($"EL Nombre es:{cliente1.NombreCliente}\n");
                WriteLine($"EL Numero de Telefeno es:{cliente1.NumeroTelefono}\n");
                WriteLine($"La Direccion del luga:{cliente1.Direccion}\n");
                WriteLine($"La Comida que encargo:{cliente1.Tipocomida}\n");
                WriteLine($"El Dia de entrega :{cliente1.Fecha}\n");
                WriteLine($"En Cuanto Tiempo quiere que le entregen su pedido:{cliente1.TiempodeEntrega}\n");
                WriteLine($"EL Total a pagar es :{cliente1.PrecioTotal}\n");

            }
            catch (ArgumentOutOfRangeException ex)
            {
                WriteLine(ex.Message);
                
            }

            Console.ReadLine();


            



        }
    }
}
