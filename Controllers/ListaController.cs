using Microsoft.AspNetCore.Mvc;
using System.Data;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;

namespace ConsultorioAPI.Controllers
{    
    [ApiController]
    public class ListaController : ControllerBase
    {
        public IConfiguration Configuration { get; }
        public ListaController(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        [HttpGet]
        [Route("/api/lista/pacientes")]
        public dynamic ListaPacientes()
        {
            var con = Configuration.GetConnectionString("OdontologiaDB");
            try
            {
                string query = "SELECT * FROM Usuario";
                using (SqlConnection connection = new SqlConnection(con))
                {
                    connection.Open();
                    SqlDataAdapter adapter = new SqlDataAdapter(query, connection);
                    DataTable data = new DataTable();
                    adapter.Fill(data);
                    return  JsonConvert.SerializeObject(data);
                }
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
