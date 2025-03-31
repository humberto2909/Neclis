using Microsoft.Extensions.Configuration;
using Microsoft.Data.SqlClient;
using Neclis.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neclis.Persistencia
{
    public class TransaccionRepository
    {
        private readonly string _cadena_conexion = "Server=LAPTOP-0LM7DLRD\\SQLEXPRESS; Database=NecliDB; Trusted_Connection=True; TrustServerCertificate=True;";
        private string sql;

        public bool RegistrarTransaccion(Transaccion transaccion)
        {
            using (SqlConnection conexion = new SqlConnection(_cadena_conexion))
            {
                conexion.Open();
                SqlTransaction trx = conexion.BeginTransaction();

                try
                {
                    // Validar existencia
                    if (!CuentaExiste(transaccion.NumeroOrigen, conexion, trx) ||
                        !CuentaExiste(transaccion.NumeroDestino, conexion, trx))
                        throw new ArgumentException("Una o ambas cuentas no existen.");

                    // Validar saldo
                    decimal saldoOrigen = ObtenerSaldo(transaccion.NumeroOrigen, conexion, trx);
                    if (transaccion.Monto < 1000 || transaccion.Monto > 5000000)
                        throw new ArgumentException("El monto debe estar entre $1.000 y $5.000.000.");
                    if (saldoOrigen < transaccion.Monto)
                        throw new ArgumentException("Saldo insuficiente en la cuenta origen.");

                    // Actualizar saldos
                    ActualizarSaldo(transaccion.NumeroOrigen, -transaccion.Monto, conexion, trx);
                    ActualizarSaldo(transaccion.NumeroDestino, transaccion.Monto, conexion, trx);

                    // Insertar transacción
                    sql = @"INSERT INTO Transacciones (Numero, Fecha, CuentaOrigen, CuentaDestino, Monto, Tipo)
                            VALUES (@Numero, @Fecha, @Origen, @Destino, @Monto, @Tipo)";

                    using (var comando = new SqlCommand(sql, conexion, trx))
                    {
                        comando.Parameters.AddWithValue("@Numero", transaccion.Numero);
                        comando.Parameters.AddWithValue("@Fecha", transaccion.Fecha);
                        comando.Parameters.AddWithValue("@Origen", transaccion.NumeroOrigen);
                        comando.Parameters.AddWithValue("@Destino", transaccion.NumeroDestino);
                        comando.Parameters.AddWithValue("@Monto", transaccion.Monto);
                        comando.Parameters.AddWithValue("@Tipo", transaccion.Tipo);
                        comando.ExecuteNonQuery();
                    }

                    trx.Commit();
                    return true;
                }
                catch
                {
                    trx.Rollback();
                    throw;
                }
            }
        }

        private bool CuentaExiste(string numero, SqlConnection conexion, SqlTransaction trx)
        {
            sql = "SELECT COUNT(*) FROM Transaccion WHERE Id = @numero";
            using (var comando = new SqlCommand(sql, conexion, trx))
            {
                comando.Parameters.AddWithValue("@numero", numero);
                return (int)comando.ExecuteScalar() > 0;
            }
        }

        private decimal ObtenerSaldo(string numero, SqlConnection conexion, SqlTransaction trx)
        {
            sql = "SELECT Saldo FROM Transaccion WHERE Id = @numero";
            using (var comando = new SqlCommand(sql, conexion, trx))
            {
                comando.Parameters.AddWithValue("@numero", numero);
                return Convert.ToDecimal(comando.ExecuteScalar());
            }
        }

        private void ActualizarSaldo(string numero, decimal cambio, SqlConnection conexion, SqlTransaction trx)
        {
            sql = "UPDATE Transaccion SET Saldo = Saldo + @cambio WHERE Id = @numero";
            using (var comando = new SqlCommand(sql, conexion, trx))
            {
                comando.Parameters.AddWithValue("@cambio", cambio);
                comando.Parameters.AddWithValue("@numero", numero);
                comando.ExecuteNonQuery();
            }
        }

        public List<Transaccion> ListarTransacciones()
        {
            var transacciones = new List<Transaccion>();

            using (var conexion = new SqlConnection(_cadena_conexion))
            {
                sql = "SELECT * FROM Transaccion";

                using (var comando = new SqlCommand(sql, conexion))
                {
                    conexion.Open();
                    var lector = comando.ExecuteReader();

                    while (lector.Read())
                    {
                        var transaccion = new Transaccion
                        {
                            Numero = lector["Numero"].ToString(),
                            Fecha = DateTime.Parse(lector["Fecha"].ToString()),
                            NumeroOrigen = lector["NumeroOrigen"].ToString(),
                            NumeroDestino = lector["NumeroDestino"].ToString(),
                            Monto = Convert.ToInt64(lector["Monto"]),
                            Tipo = lector["Tipo"].ToString()
                        };

                        transacciones.Add(transaccion);
                    }
                }
            }

            return transacciones;
        }
    }
}
