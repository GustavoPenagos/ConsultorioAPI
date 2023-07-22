using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ConsultorioAPI.Data;
using OdontologiaWeb.Models;
using Microsoft.EntityFrameworkCore;
using ConsultorioAPI.Model;

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
                return from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.Id_Documento equals TipoDocumento.Id_Documento
                            join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.Id
                            join Genero in _context.Genero on Usuario.Id_Genero equals Genero.Id_Genero
                            join Ciudad in _context.Ciudad on Usuario.Id_Ciudad equals Ciudad.Id_Ciudad
                            join Departamento in _context.Departamento on Usuario.Id_Departamento equals Departamento.Id_Departamento
                            select new
                            {
                                Usuario.Id_Usuario,
                                tipodocumento = TipoDocumento.Documento,
                                Usuario.Nombre,
                                Usuario.Apellido,
                                Usuario.Edad,
                                Usuario.Fecha_Nacido,
                                EstadoCivil= EstadoCivil.CivilNo,
                                Usuario.Ocupacion,
                                Genero = Genero.Sexo,
                                Ciudad.Municipio,
                                departamento = Departamento.NombreDepartamento

                            };
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
