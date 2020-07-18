using System;

namespace proyect
{
    public class Empresa : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        

        public Empresa() : base()
        { }

        public Empresa(int id) : base(id)
        {}

        public Empresa(string id) : base(id)
        { }

        public Zapatos ConstruirZapatos(string modelo)
        
        {
            return new Zapatos()
            {
                Marca = Nombre,
                Modelo = modelo,
            
            };
        }

        public Pago ConstruirPago(string marca, string modelo, int precio)
        {
            return new Pago { Marca = marca, Modelo = modelo, Precio = precio };
        }

        public Pedido ConstruirPedido(string modelo)
        {
       
            return new Pedido()
            {
                Marca = Nombre,
                Modelo = modelo,
               
            };
        }
    }
}