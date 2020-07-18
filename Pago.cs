namespace proyect
{
    public class Pago : MedioDeEnvio
    {
        public float Precio { get; set; }
     
        public Pago() : base()
        {
        }

        public new string Pagar()
        {
            return $"Su número de factura es {Id} {Marca} {Modelo} {base.Pagar()} ";
        }
    }
}