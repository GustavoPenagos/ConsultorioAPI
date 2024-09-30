using Data.Context;
using Microsoft.AspNetCore.Mvc;


namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class SearchController : ControllerBase
    {
        public OdontologiaContext _context;
        public SearchController(OdontologiaContext context)
        {
            _context = context;
        }


        [HttpGet]
        [Route("/api/buscar/usuario")]
        public dynamic BuscarUsuario(long id, string? fuente=null)
        {
            try
            {
                switch (fuente)
                {
                    case "registro":
                        DateTime fecha = _context.Usuario.FirstOrDefault(i => i.Id_Usuario == id).Fecha_Nacido;
                        var dias = DateTime.Now - fecha;
                        var anios = dias.Days /365;
                        return anios;
                    case "htl":
                        return from Usuario in _context.Usuario
                                           join TipoDocumento in _context.TipoDocumento on Usuario.Id_Documento equals TipoDocumento.Id_Documento
                                           join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.Id
                                           join Genero in _context.Genero on Usuario.Id_Genero equals Genero.Id_Genero
                                           join Ciudad in _context.Ciudad on Usuario.Id_Ciudad equals Ciudad.Id_Ciudad
                                           join Departamento in _context.Departamento on Usuario.Id_Departamento equals Departamento.Id_Departamento
                                           where Usuario.Id_Usuario == id
                                           select new
                                           {
                                               Usuario.Id_Usuario,
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
                                               departamento = Departamento.Departamento,
                                               fechaAtencion = Usuario.Atencion,
                                               acudiente = Usuario.Nombre_Acudiente == null ? "Ninguno" : Usuario.Nombre_Acudiente,
                                               observaciones = Usuario.Observaciones == null ? "Ninguno" : Usuario.Observaciones
                                           };

                    default:
                        return (from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.Id_Documento equals TipoDocumento.Id_Documento
                            join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.Id
                            join Genero in _context.Genero on Usuario.Id_Genero equals Genero.Id_Genero
                            join Ciudad in _context.Ciudad on Usuario.Id_Ciudad equals Ciudad.Id_Ciudad
                            join Citas in _context.Citas on Usuario.Id_Usuario equals Citas.Id_Usuario into leftJoin
                            where Usuario.Id_Usuario == id
                                   from Citas in leftJoin.DefaultIfEmpty()
                                   select new
                                   {
                                       Usuario.Id_Usuario,
                                       tipodocumento = TipoDocumento.Documento,
                                       Usuario.Nombre,
                                       Usuario.Apellido,
                                       Usuario.Edad,
                                       Genero = Genero.Sexo,
                                       citas = Citas.Fecha_Cita.ToShortDateString(),
                                       hora = Citas.Hora_Cita
                                   });
                }
                


            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpGet]
        [Route("/api/buscar/departamento")]
        public dynamic BuscarDepartamento(int id)
        {
            try
            {
                return _context.Ciudad.FirstOrDefault(c => c.Id_Ciudad == id)?.Id_Departamento;
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }
              

        [HttpGet]
        [Route("/api/buscar/citaxid")]
        public dynamic BusarCitasXId(long id)
        {
            try
            {
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario
                       where Usuario.Id_Usuario == id
                       select new
                       {
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Identificacion = Usuario.Id_Usuario,
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
            IQueryable result;
            try
            {
                if(id == 0)
                {
                    result = from Citas in _context.Citas
                           join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario
                           orderby Citas.Fecha_Cita, Citas.Hora_Cita ascending
                           select new
                           {
                               Documento = Usuario.Id_Usuario,
                               Nombre = Usuario.Nombre,
                               Apellido = Usuario.Apellido,
                               Telefono = Usuario.Telefono,
                               Fecha = Citas.Fecha_Cita.ToShortDateString(),
                               Hora = Citas.Hora_Cita
                           };
                }else
                {
                    result = from Citas in _context.Citas
                             join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario 
                             where Usuario.Id_Usuario == id 
                             select new 
                             {
                                 Documento = Usuario.Id_Usuario,
                                 Nombre = Usuario.Nombre,
                                 Apellido = Usuario.Apellido,
                                 Fecha = Citas.Fecha_Cita,
                                 Hora = Citas.Hora_Cita
                             };
                }
                

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            return result;
        }
    }
}
