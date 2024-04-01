using Desafio_1b.Data;
using Desafio_1b.Models;
using Microsoft.AspNetCore.Mvc;

namespace Desafio_1b.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FormularioController : Controller
    {
        private readonly FormularioContext _context;

        public FormularioController(FormularioContext context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetUsers()
        {
            var users = _context.Campos.ToList();

            if (users == null || users.Count == 0)
            {
                return NotFound(); 
            }

            return Ok(users);
        }

        [HttpPost("Salvar")]
        public IActionResult Salvar([FromBody] Campos campos)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Campos.Add(campos);
            _context.SaveChanges();
            return Ok(campos);
        }

        public IActionResult Sucesso()
        {
            return View();
        }
    }
}





