using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using OdontologiaWeb.Models;
using System.Diagnostics.Tracing;

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
        [Route("/registro/usuario")]
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
        [Route("/registro/anamnesis")]
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
        [Route("/registro/familiar")]
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
        [Route("/registro/estomatologico")]
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
        [Route("/registro/plantratamiento")]
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
        [Route("/registro/estadotratamiento")]
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
        [Route("/registro/dentaladulto")]
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
        [Route("/registro/dentalnino")]
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
    }
}
