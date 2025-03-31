using Microsoft.Data.SqlClient;
using Neclis.Entities;

namespace Neclis.Persistencia
{
    public class CuentaRepository
    {
        private readonly string _cadena_conexion = "Server=LAPTOP-0LM7DLRD\\SQLEXPRESS; Database=NecliDB; Trusted_Connection=True; TrustServerCertificate=True;";
        private string sql;

        public bool RegistrarCuenta(Cuenta cuenta)
        {

            using (var conexion = new SqlConnection(_cadena_conexion))
            {

                sql = @"INSERT INTO Cuenta(Id,Contrasena,Nombres,Apellidos,Email,Telefono,Saldo,FechaCreacion) 
                    VALUES(@Id,@Contrasena,@Nombres,@Apelllidos,@Email,@Telefono,@Saldo,@FechaCreacion)";


                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@Id", cuenta.Id);
                    comando.Parameters.AddWithValue("@Contrasena", cuenta.Contrasena);
                    comando.Parameters.AddWithValue("@Nombres", cuenta.Nombres);
                    comando.Parameters.AddWithValue("@Apelllidos", cuenta.Apellidos);
                    comando.Parameters.AddWithValue("@Email", cuenta.Email);
                    comando.Parameters.AddWithValue("@Telefono", cuenta.Telefono);
                    comando.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                    comando.Parameters.AddWithValue("@FechaCreacion", DateTime.Now);
                    conexion.Open();
                    comando.ExecuteNonQuery();

                }

            }
            return true;
        }

        public Cuenta ConsultarCuenta(string id)
        {
            using (var conexion = new SqlConnection(_cadena_conexion))
            {
                sql = "SELECT * FROM Cuenta WHERE Id =@Id";

                using (var comando = new SqlCommand(sql, conexion))
                {

                    comando.Parameters.AddWithValue("@Id", id);
                    conexion.Open();
                    var lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        var vehiculo = new Cuenta
                        {

                            Id = Convert.ToInt32(lector["Id"].ToString()),
                            Contrasena = lector["Contrasena"].ToString(),
                            Nombres = lector["Nombres"].ToString(),
                            Apellidos = lector["Apellidos"].ToString(),
                            Email = lector["Email"].ToString(),
                            Telefono = lector["Telefono"].ToString(),
                            Saldo = Convert.ToInt32(lector["Saldo"].ToString()),
                            FechaCreacion = DateTime.Parse(lector["FechaCreacion"].ToString())

                        };
                        return vehiculo;
                    }
                }
            }
            return null;
        }
        public List<Cuenta> ListarCuentas()
        {
            var cuentas = new List<Cuenta>();

            using (var conexion = new SqlConnection(_cadena_conexion))
            {
                sql = "SELECT * FROM Cuenta";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    var lector = comando.ExecuteReader();

                    while (lector.Read())
                    {

                        var cuenta = new Cuenta
                        {

                            Id = Convert.ToInt32(lector["Id"].ToString()),
                            Contrasena = lector["Contrasena"].ToString(),
                            Nombres = lector["Nombres"].ToString(),
                            Apellidos = lector["Apellidos"].ToString(),
                            Email = lector["Email"].ToString(),
                            Telefono = lector["Telefono"].ToString(),
                            Saldo = Convert.ToInt32(lector["Saldo"].ToString()),
                            FechaCreacion = DateTime.Parse(lector["FechaCreacion"].ToString())

                        };
                        cuentas.Add(cuenta);
                    }
                }
            }
            return cuentas;
        }

        public bool ActualizarCuenta(Cuenta cuenta)
        {
            using (var conexion = new SqlConnection(_cadena_conexion))
            {
                sql = @"UPDATE Cuenta SET Contrasena=@Contrasena,Nombres=@Nombres,Apellidos=@Apellidos,Email=@Email,Telefono=@Telefono,Saldo=@Saldo,FechaCreacion=@FechaCreacion WHERE Id=@Id";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", cuenta.Id);
                    comando.Parameters.AddWithValue("@Contrasena", cuenta.Contrasena);
                    comando.Parameters.AddWithValue("@Nombres", cuenta.Nombres);
                    comando.Parameters.AddWithValue("@Apellidos", cuenta.Apellidos);
                    comando.Parameters.AddWithValue("@Email", cuenta.Email);
                    comando.Parameters.AddWithValue("@Telefono", cuenta.Telefono);
                    comando.Parameters.AddWithValue("@Saldo", cuenta.Saldo);
                    comando.Parameters.AddWithValue("@FechaCreacion", cuenta.FechaCreacion);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }

        public bool EliminarCuenta(string id)
        {
            using (var conexion = new SqlConnection(_cadena_conexion))
            {
                sql = "DELETE FROM Cuenta WHERE Id=@Id";
                using (var comando = new SqlCommand(sql, conexion))
                {
                    comando.Parameters.AddWithValue("@Id", id);
                    conexion.Open();
                    comando.ExecuteNonQuery();
                }
            }
            return true;
        }
    }
}
