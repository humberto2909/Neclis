using Microsoft.AspNetCore.Mvc;
using Neclis.Entities;
using Neclis.LogicaDeNegocios.Dtos;
using Neclis.LogicaDeNegocios.Services;

namespace Neclis.WebApi.Controllers
{
    [ApiController]
    [Route("transacciones")]
    public class TransaccionController : ControllerBase
    {
        private readonly TransaccionServices _transaccionService;

        public TransaccionController(TransaccionServices transaccionService)
        {
            _transaccionService = transaccionService;
        }

        [HttpPost]
        public IActionResult RealizarTransaccion([FromBody] AgregarTransaccionDto dto)
        {
            try
            {
                var resultado = _transaccionService.RealizarTransaccion(dto);

                if (!resultado)
                    return BadRequest(new { mensaje = "No se pudo realizar la transacción." });

                return Ok(new { mensaje = "Transacción realizada correctamente." });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(new { mensaje = ex.Message });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

        [HttpGet]
        public ActionResult<List<Transaccion>> ObtenerTransacciones()
        {
            try
            {
                var lista = _transaccionService.ListarTransacciones();
                return Ok(lista);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error al obtener transacciones: " + ex.Message });
            }
        }
    }
}
