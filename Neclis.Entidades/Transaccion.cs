namespace Neclis.Entities
{
    public class Transaccion
    {
        public required string Numero { get; set; }
        public required DateTime? Fecha { get; set; }
        public required string NumeroOrigen { get; set; }
        public required string NumeroDestino { get; set; }
        public required decimal Monto { get; set; }
        public required string Tipo { get; set; }
    }
}
