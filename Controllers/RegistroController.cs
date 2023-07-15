using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using OdontologiaWeb.Models;

namespace ConsultorioAPI.Controllers
{
    [ApiController]
    public class RegistroController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public RegistroController(IConfiguration configuration)
        {
            Configuration = configuration;
        }


        [HttpPost]
        [Route("/registro/usuario")]
        public dynamic RegistroUsuario(Usuario usuario)
        {
            try
            {
                string query = "INSERT INTO [dbo].[Usuario]  VALUES ()";
                var con = Configuration.GetConnectionString("OdontologiaDB");
                using(SqlCommand cmd = new SqlCommand(con))
                {

                }
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
