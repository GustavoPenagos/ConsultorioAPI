using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class BuscarController : ControllerBase
    {
        public consultorioDBContext _context;
        public BuscarController(consultorioDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/buscar/usuario")]
        public dynamic BuscarUsuario(long id, string? fuente=null)
        {
            try
            {
                switch (fuente)
                {
                    case "registro":
                        DateTime fecha = _context.Usuario.Where(i => i.IdUsuario == id).Select(i => i.FechaNacido).FirstOrDefault();
                        var dias = DateTime.Now - fecha;
                        var anios = dias.Days /365;
                        return anios;
                    case "htl":
                        return from Usuario in _context.Usuario
                                           join TipoDocumento in _context.TipoDocumento on Usuario.IdDocumento equals TipoDocumento.IdDocumento
                                           join EstadoCivil in _context.EstadoCivil on Usuario.EstadoCivil equals EstadoCivil.Id
                                           join Genero in _context.Genero on Usuario.IdGenero equals Genero.IdGenero
                                           join Ciudad in _context.Ciudad on Usuario.IdCiudad equals Ciudad.IdCiudad
                                           join Departamento in _context.Departamento on Usuario.IdDepartamento equals Departamento.IdDepartamento
                                           where Usuario.IdUsuario == id
                                           select new
                                           {
                                               Usuario.IdUsuario,
                                               tipodocumento = TipoDocumento.Documento,
                                               Usuario.Nombre,
                                               Usuario.Apellido,
                                               Usuario.Edad,
                                               fecaNacido = Usuario.FechaNacido.ToShortDateString(),
                                               EstadoCivil = EstadoCivil.CivilNo,
                                               aseguradora = Usuario.Aseguradora == null ? "Ninguno" : Usuario.Aseguradora,
                                               direccion = Usuario.Direccion == null ? "Ninguno" : Usuario.Direccion,
                                               telefono = Usuario.Telefono == null ? "Ninguno" : Usuario.Telefono,
                                               Ocupacion = Usuario.Ocupacion == null ? "Ninguno" : Usuario.Ocupacion,
                                               Genero = Genero.Sexo,
                                               Ciudad.Municipio,
                                               departamento = Departamento.NombreDepartamento,
                                               fechaAtencion = Usuario.Atencion,
                                               acudiente = Usuario.NombreAcudiente == null ? "Ninguno" : Usuario.NombreAcudiente,
                                               observaciones = Usuario.Observaciones == null ? "Ninguno" : Usuario.Observaciones
                                           };

                    default:
                        var usuario = (from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.IdDocumento equals TipoDocumento.IdDocumento
                            join EstadoCivil in _context.EstadoCivil on Usuario.EstadoCivil equals EstadoCivil.Id
                            join Genero in _context.Genero on Usuario.IdGenero equals Genero.IdGenero
                            join Ciudad in _context.Ciudad on Usuario.IdCiudad equals Ciudad.IdCiudad
                            join Citas in _context.Citas on Usuario.IdUsuario equals Citas.IdUsuario into leftJoin
                               from Citas in leftJoin.DefaultIfEmpty()
                               select new
                            {
                                Usuario.IdUsuario,
                                tipodocumento = TipoDocumento.Documento,
                                Usuario.Nombre,
                                Usuario.Apellido,
                                Usuario.Edad,
                                Genero = Genero.Sexo,
                                citas = Citas.FechaCita.ToShortDateString(),
                                hora = Citas.HoraCita
                            }).Where(i => i.IdUsuario == id).ToList();
                        return usuario;
                }
                


            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">ciry id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/buscar/departamento")]
        public dynamic BuscarDepartamento(int id)
        {
            try
            {
                var departamento = _context.Ciudad.Where(c => c.IdCiudad == id).Select(d => d.IdDepartamento).ToList();
                return Convert.ToInt32(departamento[0].ToString());
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
              
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/buscar/citaxid")]
        public dynamic BusarCitasXId(long id)
        {
            try
            {
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                       where Usuario.IdUsuario == id
                       select new
                       {
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Identificacion = Usuario.IdUsuario,
                           FechaCita = Citas.FechaCita
                       };

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/buscar/citasxid")]
        public dynamic BusarCitas(long id=0)
        {
            try
            {
                if(id == 0)
                {
                    return from Citas in _context.Citas
                           join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                           orderby Citas.FechaCita, Citas.HoraCita ascending
                           select new
                           {
                               Documento = Usuario.IdUsuario,
                               Nombre = Usuario.Nombre,
                               Apellido = Usuario.Apellido,
                               Telefono = Usuario.Telefono,
                               Fecha = Citas.FechaCita.ToShortDateString(),
                               Hora = Citas.HoraCita
                           };
                }
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                       where Usuario.IdUsuario == id
                       select new
                       {
                           Documento = Usuario.IdUsuario,
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Fecha = Citas.FechaCita,
                           Hora = Citas.HoraCita
                       };

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
