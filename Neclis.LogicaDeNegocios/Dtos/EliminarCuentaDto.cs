using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neclis.LogicaDeNegocios.Dtos;

public record EliminarCuentaDto(
    int Id,
    string Contrasena,
    string Nombre,
    string Apellido,
    string Telefono,
    string Email,
    float Saldo,
    DateTime FechaCreacion
);
