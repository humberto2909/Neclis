using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neclis.LogicaDeNegocios.Dtos;

public record ConsultarTransaccionDto(
    int Numero,
    DateTime? Fecha,
    string NumeroOrigen,
    string NumeroDestino,
    float Monto,
    string Tipo
);
