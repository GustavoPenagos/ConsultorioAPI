﻿using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using ConsultorioAPI.Data;
using OdontologiaWeb.Models;
using Microsoft.EntityFrameworkCore;
using ConsultorioAPI.Model;

namespace ConsultorioAPI.Controllers
{    
    [ApiController]
    public class ListaController : ControllerBase
    {
        public consultorioDBContext _context;
        public ListaController(consultorioDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        [Route("/api/lista/pacientes")]
        public dynamic ListaPacientes()
        {
            try
            {
                 var usuario = from Usuario in _context.Usuario
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
                                citas = Citas.FechaCita.ToShortDateString(),
                                hora = Citas.HoraCita
                            };

                return usuario.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/conveccion")]
        public dynamic ListaConvecciones()
        {
            try
            {
                return _context.Convecciones.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/estadocivil")]
        public dynamic ListaEstadoCivil()
        {

            try
            {
                return _context.EstadoCivil.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/tiposdecumentos")]
        public dynamic ListaTiposDocumentos()
        {

            try
            {
                return _context.TipoDocumento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/ciudad")]
        public dynamic ListaCiudad()
        {

            try
            {
                return _context.Ciudad.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/departamento")]
        public dynamic ListaDepartamento()
        {

            try
            {

                return _context.Departamento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/genero")]
        public dynamic ListaGenero()
        {

            try
            {
                return _context.Genero.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/estadotratamiento")]
        public dynamic ListaTratamiento()
        {

            try
            {
                return _context.EstadoTratamiento.ToList();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [HttpGet]
        [Route("/api/lista/fotos")]
        public dynamic ListaFotos(long id)
        {
            try
            {
                if (id == 0)
                {
                    return _context.Imagenes.Select(i => i.Imagen).ToList();
                }
                return _context.Imagenes.Where(i => i.IdUsuario == id).Select(i => i.Imagen).ToList();

            }catch (Exception ex)
            {
                return BadRequest(ex.Message());
            }

        }


    }
}
