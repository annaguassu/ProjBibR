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

            Entidades.User usuarioLogado = db.USERS.Where(a =>
            a.email == email && a.password == password).FirstOrDefault();

            if(usuarioLogado == null)
            {
                TempData["erro"] = "Usuário e senha Inválido";
                return View();
            }

            var claims = new List<Claim>();
            claims.Add(new Claim(ClaimTypes.Name, usuarioLogado.Nome));
            claims.Add(new Claim(ClaimTypes.Sid, usuarioLogado.Id.ToString()));

            var userIdentity = new ClaimsIdentity(claims, "Acesso");
            ClaimsPrincipal principal = new ClaimsPrincipal(userIdentity);
            await HttpContext.SignInAsync("CookieAuthentication", principal, new AuthenticationProperties());

            return View();
        }
        
    }
}
