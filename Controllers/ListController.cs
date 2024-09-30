using Microsoft.AspNetCore.Mvc;
using System.Data;
using Data.Context;

namespace ConsultorioAPI.Controllers
{    
    [ApiController]
    public class ListController : Controller
    {
        public OdontologiaContext _context;
        public ListController(OdontologiaContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/api/lista/pacientes")]
        public dynamic ListaPacientes()
        {
            try
            {
                 return (from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.Id_Documento equals TipoDocumento.Id_Documento
                            join EstadoCivil in _context.EstadoCivil on Usuario.Estado_Civil equals EstadoCivil.Id
                            join Genero in _context.Genero on Usuario.Id_Genero equals Genero.Id_Genero
                            join Ciudad in _context.Ciudad on Usuario.Id_Ciudad equals Ciudad.Id_Ciudad
                            join Citas in _context.Citas on Usuario.Id_Usuario equals Citas.Id_Usuario into leftJoin
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
                return _context.Convecciones;
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
                return _context.EstadoCivil;
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
                return _context.TipoDocumento;
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
                return _context.Ciudad;
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

                return _context.Departamento;
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
                return _context.Genero;
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
                return _context.EstadoTratamiento;
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/fotos")]
        public dynamic ListaFotos(long id)
        {
            try
            {
                if (id == 0)
                {
                    return _context.Imagenes.Select(i => i.Imagen);
                }else
                {
                    return _context.Imagenes.FirstOrDefault(i => i.Id_Usuario == id).Imagen;
                }


            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


    }
}
