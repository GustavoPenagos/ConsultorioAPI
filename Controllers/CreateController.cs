using Data.Context;
using Data.Model;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.InteropServices.ObjectiveC;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class CreateController : ControllerBase
    {
        public OdontologiaContext _context;
        public CreateController(OdontologiaContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("/api/registro/usuario")]
        public IActionResult RegistroUsuario(Usuario usuario)
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
        public IActionResult RegistroAnamnesis(Anamnesis anamnesis)
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
        public IActionResult RegistroFamiliar(Ant_Familiar familiar)
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
        public IActionResult RegistroEstomatologico(Estomatologico estomatologico)
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
        public IActionResult RegistroTratamiento(PlanTratamiento tratamiento)
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
        public IActionResult RegistroEstadoTratamiento(EstadoTratamiento estado)
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
        public IActionResult RegistroCartaDentalAdulto(CartaDentalAdulto dentalAdulto)
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
        public IActionResult RegistroCartaDentalNino(CartaDentalNino dentalNino)
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
        public IActionResult RegistroCitas(Citas citas)
        {
            try
            {
                var persona = _context.Citas.FirstOrDefault(x => x.Id_Usuario == citas.Id_Usuario);
                if (persona != null)
                {
                    persona.Fecha_Cita = citas.Fecha_Cita;
                    persona.Hora_Cita = citas.Hora_Cita;
                    _context.SaveChanges();
                    return Ok();
                }
                else
                {
                    _context.Citas.Update(citas);
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
        public IActionResult RegistroImagen(Imagenes imagenes)
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
    }
}
