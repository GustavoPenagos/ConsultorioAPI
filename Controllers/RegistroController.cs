using ConsultorioAPI.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OdontologiaWeb.Models;

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
                    Observaciones = usuario.Observaciones
                };
                _context.Usuario.Add(insert);
                _context.SaveChanges();
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return "";
        }
        [HttpPost]
        [Route("/registro/anamnesis")]
        public dynamic RegistroAnamnesis(Anamnesis anamnesis)
        {
            try
            {
                var insert = new Anamnesis
                {
                   

                };

            }catch (Exception ex)
            {

            }
            return "";
        }
        [HttpPost]
        [Route("/registro/familiar")]
        public dynamic RegistroFamiliar(Ant_Familiar familiar)
        {
            return "";
        }
        [HttpPost]
        [Route("/registro/estomatologico")]
        public dynamic RegistroEstomatologico(Estomatologico estomatologico)
        {
            return "";
        }
    }
}
