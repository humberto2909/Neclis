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
    public class CuentaServices
    {
        private readonly CuentaRepository _cuentaRepository = new CuentaRepository();
        public bool RegistrarCuenta(AgregarCuentaDto agregarCuentaDto)
        {
            var cuenta = new Cuenta
            {
                Id = agregarCuentaDto.Id,
                Contrasena = agregarCuentaDto.Contrasena,
                Nombres = agregarCuentaDto.Nombre,
                Apellidos = agregarCuentaDto.Apellido,
                Telefono = agregarCuentaDto.Telefono,
                Email = agregarCuentaDto.Email,
                Saldo = agregarCuentaDto.Saldo,
                FechaCreacion = agregarCuentaDto.FechaCreacion
            };

            return _cuentaRepository.RegistrarCuenta(cuenta);
        }

        public bool ActualizarCuenta(ActualizarCuentaDto actualizarCuentaDto)
        {
            var cuenta = new Cuenta
            {
                Id = actualizarCuentaDto.Id,
                Contrasena = actualizarCuentaDto.Contrasena,
                Nombres = actualizarCuentaDto.Nombre,
                Apellidos = actualizarCuentaDto.Apellido,
                Telefono = actualizarCuentaDto.Telefono,
                Email = actualizarCuentaDto.Email,
                Saldo = actualizarCuentaDto.Saldo,
                FechaCreacion = actualizarCuentaDto.FechaCreacion
            };
            return _cuentaRepository.ActualizarCuenta(cuenta);
        }

        public bool EliminarCuenta(string id)
        {
            return _cuentaRepository.EliminarCuenta(id);
        }

        public List<ConsultarCuentaDto> ListarCuentas()
        {
            return _cuentaRepository.ListarCuentas().Select(x => new ConsultarCuentaDto(x.Id, x.Contrasena, x.Nombres, x.Apellidos, x.Telefono, x.Email, x.Saldo, x.FechaCreacion)).ToList();
        }

        public ConsultarCuentaDto ConsultarCuenta(string telefono)
        {
            var cuenta = _cuentaRepository.ConsultarCuenta(telefono);
            return new ConsultarCuentaDto(cuenta.Id, cuenta.Contrasena, cuenta.Nombres, cuenta.Apellidos, cuenta.Telefono, cuenta.Email, cuenta.Saldo, cuenta.FechaCreacion);
        }
    }
}
