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
                var insert = usuario;
                _context.Usuario.Add(insert);
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
                var insert = anamnesis;
                _context.Anamnesis.Add(insert);
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
                var insert = familiar;
                _context.Ant_Familiar.Add(insert);
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
                var insert = estomatologico;
                _context.Estomatologico.Add(insert);
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
                var insert = dentalAdulto;

                _context.cartaDentalAdulto.Add(insert);
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
                var insert = dentalNino;

                _context.cartaDentalNino.Add(insert);
                _context.SaveChanges();
                return Ok();

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpPost]
        [Route("/api/registro/citas")]
        public async Task<dynamic> RegistroCitas(Citas citas)
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
    }
}
