using Microsoft.AspNetCore.Mvc;
using Neclis.LogicaDeNegocios.Dtos;
using Neclis.LogicaDeNegocios.Services;


namespace Neclis.WebApi.Controllers
{
    [ApiController]
    [Route("cuentas")]
    public class CuentaController : ControllerBase
    {
        private readonly CuentaServices _cuentaService;

        public CuentaController(CuentaServices cuentaService)
        {
            _cuentaService = cuentaService;
        }

        // POST /cuentas
        [HttpPost]
        public IActionResult RegistrarCuenta([FromBody] AgregarCuentaDto dto)
        {
            try
            {
                var cuentaCreada = _cuentaService.RegistrarCuenta(dto);
                return Created("", cuentaCreada);
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
        public IActionResult ListarCuentas()
        {
            try
            {
                var cuentas = _cuentaService.ListarCuentas();
                return Ok(cuentas);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

        // GET /cuentas/{numero}
        [HttpGet("{numero}")]
        public IActionResult ConsultarCuenta(string id)
        {
            try
            {
                var cuenta = _cuentaService.ConsultarCuenta(id);
                if (cuenta == null)
                    return NotFound(new { mensaje = "La cuenta no existe" });

                return Ok(cuenta);
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

        // DELETE /cuentas/{numero}
        [HttpDelete("{numero}")]
        public IActionResult EliminarCuenta(string id)
        {
            try
            {
                var resultado = _cuentaService.EliminarCuenta(id);
                if (!resultado)
                    return BadRequest(new { mensaje = "La cuenta tiene más de $50.000 o no puede ser eliminada" });

                return Ok(new { mensaje = "Cuenta eliminada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

        [HttpPut("{id}")]

        public IActionResult ActualizarCuenta([FromBody] ActualizarCuentaDto dto)
        {
            try
            {
                var resultado = _cuentaService.ActualizarCuenta(dto);
                if (!resultado)
                    return BadRequest(new { mensaje = "La cuenta no existe" });
                return Ok(new { mensaje = "Cuenta actualizada correctamente" });
            }
            catch (Exception ex)
            {
                return StatusCode(500, new { mensaje = "Error interno: " + ex.Message });
            }
        }

    }
}
