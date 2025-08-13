namespace EntityFramework
{
    public class TarjetaCredito
    {
        public int id { get; set; }

        public string numerotarjeta {  get; set; }

        public float limitecredito { get; set; }

        public float saldoactual { get; set; }

        public Cliente clienteTC { get; set; }

        public EstadoTarjeta estado { get; set; }

    }
    public enum EstadoTarjeta
    {

        Activa,
        Pausada,
        Bloqueada


    }
}
