using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Newtonsoft.Json;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
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
        [Route("/api/contabilidad/agregar")]
        public dynamic AgregarContabilidad(Contabilidad contabilidad)
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

        [HttpGet]
        [Route("/api/contabilidad/consultar")]
        public dynamic ConsultarContabilidad(long id)
        {
            try
            {
                var saldo = (from Contabilidad in _context.Contabilidad
                            where Contabilidad.IdUsuario == id
                            orderby Contabilidad.Id descending
                            select new 
                            {
                                idUsuario = Contabilidad.IdUsuario,
                                valor = Contabilidad.Valor,
                                abono = Contabilidad.Abono,
                                saldo = Contabilidad.Saldo
                            }).FirstOrDefault();

                return saldo;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.ToString());
            }

        }
        #endregion

        #region Pagos
        [HttpGet]
        [Route("/api/contabilidad/pagos")]
        public dynamic Pagos(long id, double pago)
        {
            try
            {
                #region
                //if (_context.Contabilidad.Where(i => i.IdUsuario == id).Select(i => i.IdUsuario).FirstOrDefault() == 0)
                //{
                //    return BadRequest("Este usuario no existe: " + id);
                //}

                //Contabilidad contabilidad = new Contabilidad();

                //List<double> saldoList = _context.Contabilidad.OrderByDescending(i => i.FechaRegistro).Select(i => i.Saldo).ToList();
                //var saldo = saldoList.FirstOrDefault();

                //if(saldo == 0)
                //{
                //    return BadRequest("La deuda esta saldada: " + saldo);
                //}

                //double valor = saldo - pago;

                //if (valor < 0)
                //{
                //    return BadRequest("El pago es mayor a la deuda: " + valor);
                //}

                //contabilidad.IdUsuario = id;
                //contabilidad.Abono = pago;
                //contabilidad.Valor = saldo;
                //contabilidad.Saldo = valor;
                #endregion
               

                var abono = _context.Contabilidad.Where(i => i.IdUsuario == id).OrderByDescending(i => i.Id).FirstOrDefault();
                abono.Abono = pago;
                abono.Id = 0;
                abono.Saldo = abono.Saldo - pago;
                _context.Add(abono);
                _context.SaveChanges();

                return Ok(abono);

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        #endregion
    }
}
