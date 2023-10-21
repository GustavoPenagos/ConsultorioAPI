using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Controllers
{
    public class ContabilidadController : ControllerBase
    {
        #region DBcontext
        public consultorioDBContext _context;

        public ContabilidadController(consultorioDBContext context)
        {
            _context = context;
        }
        #endregion
        #region Registros contables
        [HttpPost]
        [Route("/api/Contabilidad/agregar")]
        public dynamic AgregarContabilidad(Contabilidad contabilidad, long id)
        {
            try
            {
                _context.Contabilidad.Add(contabilidad);
                _context.SaveChanges();

                return Ok();

            }catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }
            
        }
        #endregion

        #region Pagos
        [HttpPost]
        [Route("/api/Contabilidad/pagos")]
        public dynamic Pagos(long id, double pago)
        {
            try
            {
                if (_context.Contabilidad.Where(i => i.IdUsuario == id).Select(i => i.IdUsuario).FirstOrDefault() == 0)
                {
                    return BadRequest("Este usuario no existe: " + id);
                }
                               
                Contabilidad contabilidad = new Contabilidad();

                List<double> saldoList = _context.Contabilidad.OrderByDescending(i => i.FechaRegistro).Select(i => i.Saldo).ToList();
                var saldo = saldoList.FirstOrDefault();
                
                if(saldo == 0)
                {
                    return BadRequest("La deuda esta saldada: " + saldo);
                }
                
                double valor = saldo - pago;
                
                if (valor < 0)
                {
                    return BadRequest("El pago es mayor a la deuda: " + valor);
                }
                
                contabilidad.IdUsuario = id;
                contabilidad.Abono = pago;
                contabilidad.Valor = saldo;
                contabilidad.Saldo = valor;

                _context.Contabilidad.Add(contabilidad);
                _context.SaveChanges();

                return Ok(contabilidad);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        #endregion
    }
}
