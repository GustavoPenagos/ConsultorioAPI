using ConsultorioAPI.Data;
using ConsultorioAPI.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
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

        #region Buscar todo
        /// <summary>
        /// 
        /// </summary>
        /// <param name="id">user id</param>
        /// <returns></returns>
        [HttpGet]
        [Route("/api/buscar/usuario")]
        public dynamic BuscarUsuario(long id, string? fuente=null)
        {
            try
            {
                switch (fuente)
                {
                    case "registro":
                        DateTime fecha = _context.Usuario.Where(i => i.IdUsuario == id).Select(i => i.FechaNacido).FirstOrDefault();
                        var dias = DateTime.Now - fecha;
                        var anios = dias.Days /365;
                        return anios;
                    case "htl":
                        return from Usuario in _context.Usuario
                                           join TipoDocumento in _context.TipoDocumento on Usuario.IdDocumento equals TipoDocumento.IdDocumento
                                           join EstadoCivil in _context.EstadoCivil on Usuario.EstadoCivil equals EstadoCivil.Id
                                           join Genero in _context.Genero on Usuario.IdGenero equals Genero.IdGenero
                                           join Ciudad in _context.Ciudad on Usuario.IdCiudad equals Ciudad.IdCiudad
                                           join Departamento in _context.Departamento on Usuario.IdDepartamento equals Departamento.IdDepartamento
                                           where Usuario.IdUsuario == id
                                           select new
                                           {
                                               Usuario.IdUsuario,
                                               tipodocumento = TipoDocumento.Documento,
                                               Usuario.Nombre,
                                               Usuario.Apellido,
                                               Usuario.Edad,
                                               fecaNacido = Usuario.FechaNacido.ToShortDateString(),
                                               EstadoCivil = EstadoCivil.CivilNo,
                                               aseguradora = Usuario.Aseguradora == null ? "Ninguno" : Usuario.Aseguradora,
                                               direccion = Usuario.Direccion == null ? "Ninguno" : Usuario.Direccion,
                                               telefono = Usuario.Telefono == null ? "Ninguno" : Usuario.Telefono,
                                               Ocupacion = Usuario.Ocupacion == null ? "Ninguno" : Usuario.Ocupacion,
                                               Genero = Genero.Sexo,
                                               Ciudad.Municipio,
                                               departamento = Departamento.NombreDepartamento,
                                               fechaAtencion = Usuario.Atencion,
                                               acudiente = Usuario.NombreAcudiente == null ? "Ninguno" : Usuario.NombreAcudiente,
                                               observaciones = Usuario.Observaciones == null ? "Ninguno" : Usuario.Observaciones
                                           };

                    default:
                        return (from Usuario in _context.Usuario
                            join TipoDocumento in _context.TipoDocumento on Usuario.IdDocumento equals TipoDocumento.IdDocumento
                            join EstadoCivil in _context.EstadoCivil on Usuario.EstadoCivil equals EstadoCivil.Id
                            join Genero in _context.Genero on Usuario.IdGenero equals Genero.IdGenero
                            join Ciudad in _context.Ciudad on Usuario.IdCiudad equals Ciudad.IdCiudad
                            join Citas in _context.Citas on Usuario.IdUsuario equals Citas.IdUsuario into leftJoin
                               from Citas in leftJoin.DefaultIfEmpty()
                            select new
                            {
                                Usuario.IdUsuario,
                                tipodocumento = TipoDocumento.Documento,
                                Usuario.Nombre,
                                Usuario.Apellido,
                                Usuario.Edad,
                                Genero = Genero.Sexo,
                                citas = Citas.FechaCita.ToShortDateString() == null ? "Sin fecha" : Citas.FechaCita.ToShortDateString(),
                                hora = Citas.HoraCita == null ? "Sin hora" : Citas.HoraCita
                            }).Where(i => i.IdUsuario == id).ToList();
                }
                


            } catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/buscar/anamnesis")]
        public dynamic BuscarAnamnesis(long id)
        {
            try
            {
                return from Anamnesis in _context.Anamnesis
                                where Anamnesis.IdUsuario == id
                                select new
                                {
                                    motivo = Anamnesis.MotivoConsulta == null ? "Ninguno" : Anamnesis.MotivoConsulta,
                                    enfermedad = Anamnesis.EmferActual == null ? "Ninguno" : Anamnesis.EmferActual
                                };

            }catch(Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/buscar/familiar")]
        public dynamic BuscarFamiliar(long id)
        {
            try
            {
                 return (from Ant_Familiar in _context.Ant_Familiar
                       where Ant_Familiar.IdUsuario == id
                       select new
                       {
                           cancer = Ant_Familiar.Cancer == 0 ? "NO" : "SI",
                           sinusitis = Ant_Familiar.Sinusitis == 0 ? "NO" : "SI",
                           organos = Ant_Familiar.OrganosSentidos == 0 ? "NO" : "SI",
                           diabetes = Ant_Familiar.Diabetes == 0 ? "NO" : "SI",
                           infecciones = Ant_Familiar.Infecciones == 0 ? "NO" : "SI",
                           hepatitis = Ant_Familiar.Hepatitis == 0 ? "NO" : "SI",
                           gastrico = Ant_Familiar.TransGastricos == 0 ? "NO" : "SI",
                           cardiopatias = Ant_Familiar.Cardiopatias == 0 ? "NO" : "SI",
                           fiebre = Ant_Familiar.FiebReumatica == 0 ? "NO" : "SI",
                           medico = Ant_Familiar.TrataMedico == 0 ? "NO" : "SI",
                           respiratoria = Ant_Familiar.EnferRespiratoria == 0 ? "NO" : "SI",
                           hipertension = Ant_Familiar.Hipertension == 0 ? "NO" : "SI",
                           caogulatoria = Ant_Familiar.AltCoagulatorias == 0 ? "NO" : "SI",
                           neumologico = Ant_Familiar.TransNeumologico == 0 ? "NO" : "SI",
                           arterial = Ant_Familiar.TenArterial == 0 ? "NO" : "SI",
                           otros = Ant_Familiar.Otros == null ? "Ninguno" : Ant_Familiar.Otros,
                           embarazo = Ant_Familiar.Embarazo == 0 ? "NO" : "SI",
                           meses = Ant_Familiar.Meses,
                           lactancia = Ant_Familiar.Lactancia == 0 ? "NO" : "SI",
                           cepillado = Ant_Familiar.FreCepillado == 0 ? "NO" : "SI",
                           seda = Ant_Familiar.CedaDental == 0 ? "NO" : "SI",
                           observaciones = Ant_Familiar.Observaciones == null ? "Ninguno" : Ant_Familiar.Observaciones
                       }).ToList();
                
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/buscar/estomatologico")]
        public dynamic BuscarEstomatologico(long id)
        {
            try
            {
                return (from Estomatologico in _context.Estomatologico
                         where Estomatologico.IdUsuario == id
                         select new
                         {
                             labios = Estomatologico.Labios == 1 ? "NORMAL" : "ANORMAL",
                             encias = Estomatologico.Encias == 1 ? "NORMAL" : "ANORMAL",
                             paladar = Estomatologico.Paladar == 1 ? "NORMAL" : "ANORMAL",
                             carrillos = Estomatologico.Carrillos == 1 ? "NORMAL" : "ANORMAL",
                             lengua = Estomatologico.Lengua == 1 ? "NORMAL" : "ANORMAL",
                             musculos = Estomatologico.Musculos == 1 ? "NORMAL" : "ANORMAL",
                             pisoboca = Estomatologico.PisoBoca == 1 ? "NORMAL" : "ANORMAL",
                             orofaringe = Estomatologico.Orofarige == 1 ? "NORMAL" : "ANORMAL",
                             frenillos = Estomatologico.Frenillos == 1 ? "NORMAL" : "ANORMAL",
                             maxilares = Estomatologico.Maxilares == 1 ? "NORMAL" : "ANORMAL",
                             salivales = Estomatologico.GlanSalivales == 1 ? "NORMAL" : "ANORMAL"


                         }).ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/buscar/dental")]
        public dynamic BuscarDental(long id)
        {
            try
            {
                int edad = _context.Usuario.Where(i => i.IdUsuario == id).Select(i => i.Edad).FirstOrDefault();
                switch (edad)
                {
                    case (< 18):
                        var dentalNino = _context.cartaDentalNino.Where(i => i.IdUsuario == id).FirstOrDefault();
                        List<dynamic> dynamicsDN = new List<dynamic>();
                        var camposNino = new
                        {
                            c51 = Convecciones(dentalNino.c51),
                            c52 = Convecciones(dentalNino.c52),
                            c53 = Convecciones(dentalNino.c53),
                            c54 = Convecciones(dentalNino.c54),
                            c55 = Convecciones(dentalNino.c55),
                            c61 = Convecciones(dentalNino.c61),
                            c62 = Convecciones(dentalNino.c62),
                            c63 = Convecciones(dentalNino.c63),
                            c64 = Convecciones(dentalNino.c64),
                            c65 = Convecciones(dentalNino.c65),
                            c71 = Convecciones(dentalNino.c71),
                            c72 = Convecciones(dentalNino.c72),
                            c73 = Convecciones(dentalNino.c73),
                            c74 = Convecciones(dentalNino.c74),
                            c75 = Convecciones(dentalNino.c75),
                            c81 = Convecciones(dentalNino.c81),
                            c82 = Convecciones(dentalNino.c82),
                            c83 = Convecciones(dentalNino.c83),
                            c84 = Convecciones(dentalNino.c84),
                            c85 = Convecciones(dentalNino.c85),
                        };
                        dynamicsDN.Add(camposNino);
                        return dynamicsDN.ToList();
                    case (>= 18):
                        var dentalAdulto = _context.cartaDentalAdulto.Where(i => i.IdUsuario == id).FirstOrDefault();
                        List<dynamic> dynamicsDA = new List<dynamic>();
                        var camposAdult = new
                        {
                            c11 = Convecciones(dentalAdulto.c11),
                            c12 = Convecciones(dentalAdulto.c12),
                            c13 = Convecciones(dentalAdulto.c13),
                            c14 = Convecciones(dentalAdulto.c14),
                            c15 = Convecciones(dentalAdulto.c15),
                            c16 = Convecciones(dentalAdulto.c16),
                            c17 = Convecciones(dentalAdulto.c17),
                            c18 = Convecciones(dentalAdulto.c18),
                            c21 = Convecciones(dentalAdulto.c21),
                            c22 = Convecciones(dentalAdulto.c22),
                            c23 = Convecciones(dentalAdulto.c23),
                            c24 = Convecciones(dentalAdulto.c24),
                            c25 = Convecciones(dentalAdulto.c25),
                            c26 = Convecciones(dentalAdulto.c26),
                            c27 = Convecciones(dentalAdulto.c27),
                            c28 = Convecciones(dentalAdulto.c28),
                            c31 = Convecciones(dentalAdulto.c31),
                            c32 = Convecciones(dentalAdulto.c32),
                            c33 = Convecciones(dentalAdulto.c33),
                            c34 = Convecciones(dentalAdulto.c34),
                            c35 = Convecciones(dentalAdulto.c35),
                            c36 = Convecciones(dentalAdulto.c36),
                            c37 = Convecciones(dentalAdulto.c37),
                            c38 = Convecciones(dentalAdulto.c38),
                            c41 = Convecciones(dentalAdulto.c41),
                            c42 = Convecciones(dentalAdulto.c42),
                            c43 = Convecciones(dentalAdulto.c43),
                            c44 = Convecciones(dentalAdulto.c44),
                            c45 = Convecciones(dentalAdulto.c45),
                            c46 = Convecciones(dentalAdulto.c46),
                            c47 = Convecciones(dentalAdulto.c47),
                            c48 = Convecciones(dentalAdulto.c48),
                        };
                        dynamicsDA.Add(camposAdult);
                        return dynamicsDA.ToList();
                    default: 
                        return 0;
                }   
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }


        #endregion
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
                var departamento = _context.Ciudad.Where(c => c.IdCiudad == id).Select(d => d.IdDepartamento).ToList();
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
        [Route("/api/buscar/citaxid")]
        public dynamic BusarCitasXId(long id)
        {
            try
            {
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                       where Usuario.IdUsuario == id
                       select new
                       {
                           Nombre = Usuario.Nombre,
                           Apellido = Usuario.Apellido,
                           Identificacion = Usuario.IdUsuario,
                           FechaCita = Citas.FechaCita
                       };

            }
            catch(Exception ex)
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
        [Route("/api/buscar/citasxid")]
        public dynamic BusarCitas(long id=0)
        {
            try
            {
                if(id == 0)
                {
                    return from Citas in _context.Citas
                           join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                           orderby Citas.FechaCita, Citas.HoraCita ascending
                           select new
                           {
                               Documento = Usuario.IdUsuario,
                               Nombre = Usuario.Nombre,
                               Apellido = Usuario.Apellido,
                               Telefono = Usuario.Telefono,
                               Fecha = Citas.FechaCita.ToShortDateString(),
                               Hora = Citas.HoraCita
                           };
                }
                return from Citas in _context.Citas
                       join Usuario in _context.Usuario on Citas.IdUsuario equals Usuario.IdUsuario
                       where Usuario.IdUsuario == id
                       select new
                       {
                           Documento = Usuario.IdUsuario,
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

        [HttpGet]
        [Route("/api/buscar/conveccionesxid")]
        public dynamic Convecciones(string id)
        {
            try
            {
                var x = _context.Convecciones.Where(i => i.Id == Convert.ToInt16(id)).Select(i => i.Conveccion).FirstOrDefault();
                return x;
            }
            catch (Exception ex)
            {
                return "Error";
            }
        }
    }
}
