using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Threading.Tasks;

namespace ProjBibR.Controllers
{
    public class LoginController : Controller
    {
        private readonly Contexto db;

        public LoginController(Contexto contexto)
        {
            db = contexto;
        }

        public IActionResult Logar()
        {
            return View();
        }
        [HttpPost]

        public async Task<ActionResult> Logar(string email, string password)
        {
            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                TempData["erro"] = "Os campos não podem estar vazios";
            }


            return View();
        }
        
    }
}
