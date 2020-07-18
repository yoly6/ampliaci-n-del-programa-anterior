namespace proyect
{
    public class Producto : GeneradorAutomaticoIdentificacion
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Persona Vendedor { get; set; }

        public Producto() : base()
        {
        }
    }
}
