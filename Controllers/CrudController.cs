﻿using ConsultorioAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class CrudController : ControllerBase
    {
        public consultorioDBContext _context;
        public CrudController(consultorioDBContext context)
        {
            _context = context;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpDelete]
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
                var anam = _context.Anamnesis.Where(b => b.IdUsuario == id);
                if (anam != null)
                {
                    _context.Anamnesis.RemoveRange(anam);
                    _context.SaveChanges();
                }
                var fam = _context.Ant_Familiar.Where(b => b.IdUsuario == id);
                if (fam != null)
                {
                    _context.Ant_Familiar.RemoveRange(fam);
                    _context.SaveChanges();
                }
                var dNino = _context.cartaDentalNino.Where(b => b.IdUsuario == id);
                if (dNino != null)
                {
                    _context.cartaDentalNino.RemoveRange(dNino);
                    _context.SaveChanges();
                }
                var dAdl = _context.cartaDentalAdulto.Where(b => b.IdUsuario == id);
                if (dAdl != null)
                {
                    _context.cartaDentalAdulto.RemoveRange(dAdl);
                    _context.SaveChanges();
                }
                var eTrta = _context.EstadoTratamiento.Where(b => b.IdUsuario == id);
                if (eTrta != null)
                {
                    _context.EstadoTratamiento.RemoveRange(eTrta);
                    _context.SaveChanges();
                }
                var estoma = _context.Estomatologico.Where(b => b.IdUsuario == id);
                if (estoma != null)
                {
                    _context.Estomatologico.RemoveRange(estoma);
                    _context.SaveChanges();
                }
                var plan = _context.PlanTratamiento.Where(b => b.IdUsuario == id);
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

        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpDelete]
        [Route("/api/eliminar/cita")]
        public dynamic EliminarCita(long id)
        {
            try
            {
                var cita = _context.Citas.Where(x => x.IdUsuario == id).FirstOrDefault();
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


        [HttpDelete]
        [Route("/api/eliminar/foto")]
        public dynamic EliminarFoto(long id, string name)
        {
            try
            {
                var foto = _context.Imagenes.Where(x => x.IdUsuario == id &&  x.Imagen == name).FirstOrDefault();
                if (foto != null)
                {
                    _context.Imagenes.RemoveRange(foto);
                    _context.SaveChanges();
                }
                return Ok();
            }catch(Exception ex)
            {
                return BadRequest();
            }
        }

    }
}
