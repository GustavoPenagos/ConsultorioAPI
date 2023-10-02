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
        public consultorioDBContext _context;
        public RegistroController(consultorioDBContext context)
        {
            _context = context;
        }

        [HttpPost]
        [Route("/api/registro/usuario")]
        public dynamic RegistroUsuario(Usuario usuario)
        {
            try
            {
                usuario.Atencion = DateTime.Now;

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
                anamnesis.Atencion = DateTime.Now;

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
                familiar.Atencion= DateTime.Now;

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
                estomatologico.Atencion = DateTime.Now;

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
                var insert = tratamiento;
                _context.PlanTratamiento.Add(insert);
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
                var insert = estado;
                _context.EstadoTratamiento.Add(insert);
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
                dentalAdulto.Atencion = DateTime.Now;

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
                dentalNino.Atencion = DateTime.Now;

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
                var persona = _context.Citas.Where(x => x.Id_Usuario == citas.Id_Usuario).FirstOrDefault();
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
                        Id_Usuario = citas.Id_Usuario,
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
    }
}
