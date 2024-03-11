using Microsoft.AspNetCore.Mvc;

namespace Cp1_Estoque_de_livro.Controllers
{
    [ApiController]
    [Route("/api/[controller]")]
    public class LivroController : ControllerBase
    {
        private static Livro Livro1 = new Livro();

        [HttpGet]
        public ActionResult<Livro> get()
        {
            return Ok(Livro1);
        }
    }
}
