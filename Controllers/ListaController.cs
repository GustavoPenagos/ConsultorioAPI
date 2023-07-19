using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ConsultorioAPI.Data;

namespace ConsultorioAPI.Controllers
{    
    [ApiController]
    public class ListaController : ControllerBase
    {
        public consultorioDBContext _context;
        public ListaController(consultorioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/api/lista/pacientes")]
        public dynamic ListaPacientes()
        {
            
            try
            {
                return _context.Usuario.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/conveccion")]
        public dynamic ListaConvecciones()
        {
            try
            {
                return _context.Convecciones.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/estadocivil")]
        public dynamic ListaEstadoCivil()
        {

            try
            {
                return _context.EstadoCivil.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/tiposdecumentos")]
        public dynamic ListaTiposDocumentos()
        {

            try
            {
                return _context.TipoDocumento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/ciudad")]
        public dynamic ListaCiudad()
        {

            try
            {
                return _context.Ciudad.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/departamento")]
        public dynamic ListaDepartamento()
        {

            try
            {

                return _context.Departamento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/genero")]
        public dynamic ListaGenero()
        {

            try
            {
                return _context.Genero.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/estadotratamiento")]
        public dynamic ListaTratamiento()
        {

            try
            {
                return _context.EstadoTratamiento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
