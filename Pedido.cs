namespace proyect
{
    public class Pedido : MedioDeEnvio
    {
        public float Consumo { get; set; }
        public string Productos { get; set; }

        public Pedido() : base()
        {
        }
    }
}
