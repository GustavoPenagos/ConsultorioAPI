using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OdontologiaWeb.Models;
using System.Diagnostics.Tracing;
using ConsultorioAPI.Controllers;
using System.Runtime.CompilerServices;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class RegistroController : ControllerBase
    {
        #region BDcontext
        public consultorioDBContext _context;
        public RegistroController(consultorioDBContext context)
        {
            _context = context;
        }
        #endregion

        [HttpPost]
        [Route("/api/registro/usuario")]
        public dynamic RegistroUsuario(Usuario usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/anamnesis")]
        public dynamic RegistroAnamnesis(Anamnesis anamnesis)
        {
            try
            {
                _context.Anamnesis.Add(anamnesis);
                _context.SaveChanges();
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/familiar")]
        public dynamic RegistroFamiliar(Ant_Familiar familiar)
        {
            try
            {
                _context.Ant_Familiar.Add(familiar);
                _context.SaveChanges();
                return Ok();

            }
            catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/estomatologico")]
        public dynamic RegistroEstomatologico(Estomatologico estomatologico)
        {
            try
            {
                _context.Estomatologico.Add(estomatologico);
                _context.SaveChanges();
                return Ok();

            }catch(Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/plantratamiento")]
        public dynamic RegistroTratamiento(PlanTratamiento tratamiento)
        {
            try
            {
                _context.PlanTratamiento.Add(tratamiento);
                _context.SaveChanges();
                return Ok();

            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/estadotratamiento")]
        public dynamic RegistroEstadoTratamiento(EstadoTratamiento estado)
        {
            try
            {
                _context.EstadoTratamiento.Add(estado);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/dentaladulto")]
        public dynamic RegistroCartaDentalAdulto(CartaDentalAdulto dentalAdulto)
        {
            try
            {
                _context.cartaDentalAdulto.Add(dentalAdulto);
                _context.SaveChanges();
                return Ok();

            }catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/dentalnino")]
        public dynamic RegistroCartaDentalNino(CartaDentalNino dentalNino)
        {
            try
            {
                _context.cartaDentalNino.Add(dentalNino);
                _context.SaveChanges();
                return Ok();

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/citas")]
        public dynamic RegistroCitas(Citas citas)
        {
            try
            {
                var persona = _context.Citas.Where(x => x.IdUsuario == citas.IdUsuario).FirstOrDefault();
                if (persona != null)
                {
                    persona.FechaCita = citas.FechaCita;
                    persona.HoraCita = citas.HoraCita;
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    Citas cita = new Citas
                    {
                        IdUsuario = citas.IdUsuario,
                        FechaCita = citas.FechaCita,
                        HoraCita = citas.HoraCita
                    };

                    _context.Citas.Update(cita);
                    _context.SaveChanges();
                    return Ok();
                }
               
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/imagen")]
        public dynamic RegistroImagen(Imagenes imagenes)
        {
            try
            {
                _context.Imagenes.Add(imagenes);
                _context.SaveChanges();
                return Ok();

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/urgencia")]
        public dynamic RegistroUrgencia(Urgencia urgencia)
        {
            try
            {

                _context.Urgencias.Add(urgencia);
                _context.SaveChanges();
                return Ok();
            }catch(Exception ex) 
            { 
                return BadRequest(ex.Message);
            }
        }
    }
}
