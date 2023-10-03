using Microsoft.AspNetCore.Mvc;

namespace ConsultorioAPI.Controllers
{
    public class ContabilidadController : ControllerBase
    {
        #region Registros contables
        public IActionResult RegistrarCuenta()
        {
            try
            {

                return Ok();

            }catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }
            #endregion
    }
}
