using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
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
                var insert = new Usuario
                {
                    Id_Usuario = usuario.Id_Usuario,
                    Id_Documento = usuario.Id_Documento,
                    Nombre = usuario.Nombre,
                    Apellido = usuario.Apellido,
                    Edad = usuario.Edad,
                    Fecha_Nacido = usuario.Fecha_Nacido,
                    Estado_Civil = usuario.Estado_Civil,
                    Ocupacion = usuario.Ocupacion,
                    Aseguradora =usuario.Aseguradora,
                    Direccion = usuario.Direccion,
                    Telefono=usuario.Telefono,
                    Id_Genero = usuario.Id_Genero,
                    Id_Ciudad = usuario.Id_Ciudad,
                    Id_Departamento = usuario.Id_Departamento,
                    Oficina = usuario.Oficina,
                    Nombre_Acudiente=usuario.Nombre_Acudiente,
                    Referido = usuario.Referido,
                    Observaciones = usuario.Observaciones,
                    Atencion = usuario.Atencion
                };
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
                var insert = new Anamnesis
                {
                   Id_Usuario = anamnesis.Id_Usuario,
                   Motivo_Consulta = anamnesis.Motivo_Consulta,
                   Emf_Actual = anamnesis.Emf_Actual,
                   Atencion = anamnesis.Atencion
                };
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
                var insert = new Ant_Familiar
                {
                    Id_Usuario = familiar.Id_Usuario,
                    Cancer = familiar.Cancer,
                    Sinusitis = familiar.Sinusitis,
                    Organos_Sentidos = familiar.Organos_Sentidos,
                    Diabetes = familiar.Diabetes,
                    Infecciones = familiar.Infecciones,
                    Hepatitis = familiar.Hepatitis,
                    Trans_Gastricos = familiar.Trans_Gastricos,
                    Cardiopatias = familiar.Cardiopatias,
                    Fieb_Reumatica = familiar.Fieb_Reumatica,
                    Trata_Medico = familiar.Trata_Medico,
                    Enf_Respiratoria = familiar.Enf_Respiratoria,
                    Hipertension = familiar.Hipertension,
                    Alt_Coagulatorias = familiar.Alt_Coagulatorias,
                    Trans_Neumologico = familiar.Trans_Neumologico,
                    Ten_Arterial = familiar.Ten_Arterial,
                    Otros = familiar.Otros,
                    Embarazo = familiar.Embarazo,
                    Meses = familiar.Meses,
                    Lactancia = familiar.Lactancia,
                    Fre_Cepillado = familiar.Fre_Cepillado,
                    Ceda_Dental = familiar.Ceda_Dental,
                    Observaciones = familiar.Observaciones,
                    Atencion = familiar.Atencion

                };
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
                var inser = new Estomatologico
                {
                    Id_Usuario = estomatologico.Id_Usuario,
                    Labios = estomatologico.Labios,
                    Encias = estomatologico.Encias,
                    Paladar = estomatologico .Paladar,
                    Carrillos = estomatologico.Carrillos,
                    Lengua = estomatologico.Lengua,
                    Musculos = estomatologico.Musculos,
                    Piso_Boca = estomatologico.Piso_Boca,
                    Orofarige = estomatologico.Orofarige,
                    Frenillos = estomatologico.Frenillos,
                    Maxilares = estomatologico.Maxilares,
                    Glan_Salivales = estomatologico.Glan_Salivales,
                    Atencion = estomatologico.Atencion
                };
                _context.Estomatologico.Add(inser);
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
                var insert = new PlanTratamiento
                {
                    Id_Usuario = tratamiento.Id_Usuario,
                    Diagnostico = tratamiento.Diagnostico,
                    Pronostico = tratamiento.Pronostico,
                    Tratamiento = tratamiento.Tratamiento,
                    Atencion = tratamiento.Atencion
                };
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
                var insert = new EstadoTratamiento
                {
                    Id_Usuario = estado.Id_Usuario,
                    Fecha = estado.Fecha,
                    Diente = estado.Diente,
                    Trata_Efectuado = estado.Trata_Efectuado,
                    Doctor = estado.Doctor,
                    Firma = estado.Firma,
                    Atencion = estado.Atencion
                };
                _context.EstadoTratamiento.Add(insert);
                _context.SaveChanges();

                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
