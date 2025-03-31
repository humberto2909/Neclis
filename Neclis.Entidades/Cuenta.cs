namespace Neclis.Entities
{
    public class Cuenta
    {
        public required int Id { get; set; }
        public required string Contrasena { get; set; }
        public required string Nombres { get; set; }
        public required string Apellidos { get; set; }
        public required string Email { get; set; }
        public required string Telefono { get; set; }
        public required float Saldo { get; set; }
        public required DateTime? FechaCreacion { get; set; }
    }
}
