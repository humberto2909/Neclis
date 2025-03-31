using Neclis.Entities;
using Neclis.LogicaDeNegocios.Dtos;
using Neclis.Persistencia;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neclis.LogicaDeNegocios.Services
{
    public class TransaccionServices
    {
        private readonly TransaccionRepository _transaccionRepository;

        public TransaccionServices(TransaccionRepository transaccionRepository)
        {
            _transaccionRepository = transaccionRepository;
        }

        public bool RealizarTransaccion(AgregarTransaccionDto dto)
        {
            if (string.IsNullOrEmpty(dto.NumeroOrigen) || string.IsNullOrEmpty(dto.NumeroDestino))
                throw new ArgumentException("Las cuentas no pueden estar vacías.");

            if (dto.NumeroOrigen == dto.NumeroDestino)
                throw new ArgumentException("No se puede transferir a la misma cuenta.");

            if (dto.Monto < 1000 || dto.Monto > 5000000)
                throw new ArgumentException("El monto debe estar entre $1.000 y $5.000.000.");

            var transaccion = new Transaccion
            {
                Numero = Guid.NewGuid().ToString(),
                NumeroOrigen = dto.NumeroOrigen,
                NumeroDestino = dto.NumeroDestino,
                Monto = (decimal)dto.Monto,
                Fecha = DateTime.Now,
                Tipo = "salida" 
            };

            return _transaccionRepository.RegistrarTransaccion(transaccion);
        }

        public List<Transaccion> ListarTransacciones()
        {
            return _transaccionRepository.ListarTransacciones();
        }


    }
}
