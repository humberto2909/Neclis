using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Neclis.LogicaDeNegocios.Dtos;

public record AgregarTransaccionDto(
    string NumeroOrigen,
    string NumeroDestino,
    float Monto
    );

