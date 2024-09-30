using Data.Context;
using Data.Model;
using Microsoft.AspNetCore.Mvc;


namespace ConsultorioAPI.Controllers
{
    public class DeleteController : ControllerBase
    {
        public OdontologiaContext _context;
        public DeleteController(OdontologiaContext context)
        {
            _context = context;
        }


        [HttpDelete]
        [Route("/api/eliminar/usuario")]
        public IActionResult EliminarUsuario(long id)
        {
            try
            {
                Usuario user = _context.Usuario.Find(id);
                if (user != null)
                {
                    _context.Usuario.RemoveRange(user);
                    _context.SaveChanges();
                }
                IQueryable<Anamnesis> anam = _context.Anamnesis.Where(b => b.Id_Usuario == id);
                if (anam != null)
                {
                    _context.Anamnesis.RemoveRange(anam);
                    _context.SaveChanges();
                }
                IQueryable<Ant_Familiar> fam = _context.Ant_Familiar.Where(b => b.Id_Usuario == id);
                if (fam != null)
                {
                    _context.Ant_Familiar.RemoveRange(fam);
                    _context.SaveChanges();
                }
                IQueryable<CartaDentalNino> dNino = _context.cartaDentalNino.Where(b => b.Id_Usuario == id);
                if (dNino != null)
                {
                    _context.cartaDentalNino.RemoveRange(dNino);
                    _context.SaveChanges();
                }
                IQueryable<CartaDentalAdulto> dAdl = _context.cartaDentalAdulto.Where(b => b.Id_Usuario == id);
                if (dAdl != null)
                {
                    _context.cartaDentalAdulto.RemoveRange(dAdl);
                    _context.SaveChanges();
                }
                IQueryable<EstadoTratamiento> eTrta = _context.EstadoTratamiento.Where(b => b.Id_Usuario == id);
                if (eTrta != null)
                {
                    _context.EstadoTratamiento.RemoveRange(eTrta);
                    _context.SaveChanges();
                }
                IQueryable<Estomatologico> estoma = _context.Estomatologico.Where(b => b.Id_Usuario == id);
                if (estoma != null)
                {
                    _context.Estomatologico.RemoveRange(estoma);
                    _context.SaveChanges();
                }
                IQueryable<PlanTratamiento> plan = _context.PlanTratamiento.Where(b => b.Id_Usuario == id);
                if (plan != null)
                {
                    _context.PlanTratamiento.RemoveRange(plan);
                    _context.SaveChanges();
                }


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        [HttpDelete]
        [Route("/api/eliminar/cita")]
        public IActionResult EliminarCita(long id)
        {
            try
            {
                Citas? cita = _context.Citas.FirstOrDefault(x => x.Id_Usuario == id);
                if(cita != null)
                {
                    _context.Citas.RemoveRange(cita);
                    _context.SaveChanges();
                }
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #region
        /*
        [HttpPost]
        [Route("/api/editar/usuario")]
        public dynamic Editarusuario(Usuario usuario)
        {
            try
            {


                return Ok();
            }catch(Exception ex)
            {
                return BadRequest(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        [HttpPost]
        [Route("/api/editar/anamnesis")]
        public dynamic EditarAnamnesis(Anamnesis anamnesis)
        {
            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        [HttpPost]
        [Route("/api/editar/familiar")]
        public dynamic EditarFamiliar(Ant_Familiar familiar)
        {
            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }

        [HttpPost]
        [Route("/api/editar/estomatologico")]
        public dynamic EditarEstomatologico(Estomatologico estomatologico)
        {
            try
            {


                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message + Environment.NewLine + ex.StackTrace);
            }
        }
        */
        #endregion
    }
}
