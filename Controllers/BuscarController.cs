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
                        DateTime fecha = _context.Usuario.Where(i => i.ID_Usuario == id).Select(i => i.Fecha_Nacido).FirstOrDefault();
                        var dias = DateTime.Now - fecha;
                        var anios = dias.Days /365;
                        return anios;
                    case "htl":
                        return from Usuario in _context.Usuario
                                           join TipoDocumento in _context.TipoDocumento on Usuario.ID_Documento equals TipoDocumento.ID_Documento
                               join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.ID
                                           join Genero in _context.Genero on Usuario.ID_Genero equals Genero.ID_Genero
                                           join Ciudad in _context.Ciudad on Usuario.ID_Ciudad equals Ciudad.ID_Ciudad
                                           join Departamento in _context.Departamento on Usuario.ID_Departamento equals Departamento.ID_Departamento
                                           where Usuario.ID_Usuario == id
                                           select new
                                           {
                                               Usuario.ID_Usuario,
                                               tipodocumento = TipoDocumento.Documento,
                                               Usuario.Nombre,
                                               Usuario.Apellido,
                                               Usuario.Edad,
                                               fecaNacido = Usuario.Fecha_Nacido.ToShortDateString(),
                                               EstadoCivil = EstadoCivil.CivilNo,
                                               aseguradora = Usuario.Aseguradora == null ? "Ninguno" : Usuario.Aseguradora,
                                               direccion = Usuario.Direccion == null ? "Ninguno" : Usuario.Direccion,
                                               telefono = Usuario.Telefono == null ? "Ninguno" : Usuario.Telefono,
                                               Ocupacion = Usuario.Ocupacion == null ? "Ninguno" : Usuario.Ocupacion,
                                               Genero = Genero.Sexo,
                                               Ciudad.Municipio,
                                               departamento = Departamento.Nombre_Departamento,
                                               fechaAtencion = Usuario.Atencion,
                                               acudiente = Usuario.Nombre_Acudiente == null ? "Ninguno" : Usuario.Nombre_Acudiente,
                                               observaciones = Usuario.Observaciones == null ? "Ninguno" : Usuario.Observaciones
                                           };

                    default:
                        var usuario = (from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.ID_Documento equals TipoDocumento.ID_Documento
                            join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.ID
                            join Genero in _context.Genero on Usuario.ID_Genero equals Genero.ID_Genero
                            join Ciudad in _context.Ciudad on Usuario.ID_Ciudad equals Ciudad.ID_Ciudad
                            join Citas in _context.Citas on Usuario.ID_Usuario equals Citas.ID_Usuario into leftJoin
                               from Citas in leftJoin.DefaultIfEmpty()
                               select new
                            {
                                Usuario.ID_Usuario,
                                tipodocumento = TipoDocumento.Documento,
                                Usuario.Nombre,
                                Usuario.Apellido,
                                Usuario.Edad,
                                Genero = Genero.Sexo,
                                citas = Citas.Fecha_Cita.ToShortDateString(),
                                hora = Citas.Hora_Cita
                            }).Where(i => i.ID_Usuario == id).ToList();
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
                var departamento = _context.Ciudad.Where(c => c.ID_Ciudad == id).Select(d => d.ID_Departamento).ToList();
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
                       join Usuario in _context.Usuario on Citas.ID_Usuario equals Usuario.ID_Usuario
                       where Usuario.ID_Usuario == id
                       select new
                       {
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Identificacion = Usuario.ID_Usuario,
                           FechaCita = Citas.Fecha_Cita
                       };

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/buscar/citasxid")]
        public dynamic BusarCitas(long id=0)
        {
            try
            {
                if(id == 0)
                {
                    return from Citas in _context.Citas
                           join Usuario in _context.Usuario on Citas.ID_Usuario equals Usuario.ID_Usuario
                           orderby Citas.Fecha_Cita, Citas.Hora_Cita ascending
                           select new
                           {
                               Documento = Usuario.ID_Usuario,
                               Nombre = Usuario.Nombre,
                               Apellido = Usuario.Apellido,
                               Telefono = Usuario.Telefono,
                               Fecha = Citas.Fecha_Cita.ToShortDateString(),
                               Hora = Citas.Hora_Cita
                           };
                }
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.ID_Usuario equals Usuario.ID_Usuario
                       where Usuario.ID_Usuario == id
                       select new
                       {
                           Documento = Usuario.ID_Usuario,
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Fecha = Citas.Fecha_Cita,
                           Hora = Citas.Hora_Cita
                       };

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
