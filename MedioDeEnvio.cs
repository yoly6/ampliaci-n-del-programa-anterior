namespace proyect
{
    public abstract class MedioDeEnvio : Producto
    {
        public MedioDeEnvio() : base()
        {
        }

        public string Servipagos()
        {
            return "problemas en el sistema";
        }

        public string Pagar()
        {
            return "su depósito se a realizado con éxito";
        }
    }
}
