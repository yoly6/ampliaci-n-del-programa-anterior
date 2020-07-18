using System;

namespace proyect
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.WriteLine("Bienvenido a la aplicacion de CarritoDeCompra en breves se conecta un acesor para confirmar su pedido");
            Console.WriteLine("------------------------------------------------------------------------");
            Console.ReadKey();

           Console.WriteLine("Ingresa tu nombre: ");
            var nombre = Console.ReadLine();
         Console.WriteLine("------------------------------------------------------------------------");

            var empresa = new Empresa();

            var cliente = new Persona("Marta", "López")
        
            {
                Zapatos = empresa.ConstruirZapatos("zapatos de taco alto")
            };
            
            cliente.Pedido = empresa.ConstruirPedido("Zapatos");
            cliente.Pago = empresa.ConstruirPago(",pago", "efectivo", 25);

            Console.WriteLine(cliente.Saludar());
            Console.WriteLine(cliente.IndicarZapatos());
            Console.WriteLine(cliente.Pago.Pagar());
            var saludo = cliente.DespedirPersona(nombre);
             Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine(saludo);
            Console.ReadKey();
            
        }
    }
}
