using clinica.Serviços;
using Microsoft.AspNetCore.Mvc;

namespace clinica.Controllers
{
    public class HomeController : Controller
    {

        private static HttpClient httpcliente = new HttpClient();

        [HttpGet("consulta exame")]

        

        public IActionResult Index()
        {
            return View();
        }

        
    }
}
