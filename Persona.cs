using System;

namespace proyect
{
    public class Persona : GeneradorAutomaticoIdentificacion
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        private Zapatos zapatos;
        public Zapatos Zapatos
        {
            get { return zapatos; }
            set
            {
                zapatos = value;
                zapatos.Vendedor = this;
            }
        }

        private Pedido pedido;
        public Pedido Pedido {
            get { return pedido; }
            set
            {
                pedido = value;
                pedido.Vendedor = this;
            }
        }

        private Pago pago;
        public Pago Pago {
            get { return pago; }
            set
            {
                pago = value;
                pago.Vendedor = this;
            }
        }
        public string SaludarPersona(string nombre)
        {
            return $"Hola {nombre} soy {Nombre}";
        }
        public string DespedirPersona(string nombre)
        {
            return $"Gracias Por su Compra!!!";
        }

        public Persona(string nombre, string apellido) : base()
        {
            Nombre = nombre;
            Apellido = apellido;
        }

        public string Saludar()
        {
            return $"Bienvenido, me llamo {Nombre} {Apellido} es un placer su orden es el siguiente.";
        }

        public string IndicarZapatos()
        {
            return $"Unos {Zapatos.Modelo} y su Id o serie es {Zapatos.Id}";
        }
        
        
    }
}
