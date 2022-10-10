using Microsoft.AspNetCore.Mvc;

namespace IfoodApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }
    }
}
