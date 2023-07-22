using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
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
        public dynamic BuscarUsuario(long id)
        {
            try
            {
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
                           Usuario.Fecha_Nacido,
                           EstadoCivil = EstadoCivil.CivilNo,
                           Usuario.Ocupacion,
                           Genero = Genero.Sexo,
                           Ciudad.Municipio,
                           departamento = Departamento.NombreDepartamento

                       };


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
                var departamento = _context.Ciudad.Where(c => c.Id_Ciudad == id).Select(d => d.Id_Departamento).ToList();
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
        [Route("/api/eliminar/usuario")]
        public dynamic EliminarUsuario(long id)
        {
            try
            {
                var user = _context.Usuario.Find(id);
                if (user != null)
                {
                    _context.Usuario.RemoveRange(user);
                    _context.SaveChanges();
                }
                var anam = _context.Anamnesis.Where(b => b.Id_Usuario == id);
                if (anam != null)
                {
                    _context.Anamnesis.RemoveRange(anam);
                    _context.SaveChanges();
                }
                var fam = _context.Ant_Familiar.Where(b => b.Id_Usuario == id);
                if (fam != null)
                {
                    _context.Ant_Familiar.RemoveRange(fam);
                    _context.SaveChanges();
                }
                var dNino = _context.cartaDentalNino.Where(b => b.Id_Usuario == id);
                if (dNino != null)
                {
                    _context.cartaDentalNino.RemoveRange(dNino);
                    _context.SaveChanges();
                }
                var dAdl = _context.cartaDentalAdulto.Where(b => b.Id_Usuario == id);
                if (dAdl != null)
                {
                    _context.cartaDentalAdulto.RemoveRange(dAdl);
                    _context.SaveChanges();
                }
                var eTrta = _context.EstadoTratamiento.Where(b => b.Id_Usuario == id);
                if (eTrta != null)
                {
                    _context.EstadoTratamiento.RemoveRange(eTrta);
                    _context.SaveChanges();
                }
                var estoma = _context.Estomatologico.Where(b => b.Id_Usuario == id);
                if (estoma != null)
                {
                    _context.Estomatologico.RemoveRange(estoma);
                    _context.SaveChanges();
                }
                var plan = _context.PlanTratamiento.Where(b => b.Id_Usuario == id);
                if (plan != null)
                {
                    _context.PlanTratamiento.RemoveRange(plan);
                    _context.SaveChanges();
                }


                return Ok();
            } catch (Exception ex)
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
                       join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario
                       where Usuario.Id_Usuario == id
                       select new
                       {
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Identificacion = Usuario.Id_Usuario,
                           CitaNueva = Citas.FechaCita
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
                           join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario
                           orderby Citas.FechaCita, Citas.HoraCita ascending
                           select new
                           {
                               Documento = Usuario.Id_Usuario,
                               Nombre = Usuario.Nombre,
                               Apellido = Usuario.Apellido,
                               Fecha = Citas.FechaCita.ToShortDateString(),
                               Hora = Citas.HoraCita
                           };
                }
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.Id_Usuario equals Usuario.Id_Usuario
                       where Usuario.Id_Usuario == id
                       select new
                       {
                           Documento = Usuario.Id_Usuario,
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
