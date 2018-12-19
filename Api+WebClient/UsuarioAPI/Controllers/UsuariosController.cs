using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using UsuarioAPI.Context;
using UsuarioAPI.Models;

namespace UsuarioAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsuariosController : ControllerBase
    {
        private readonly ApiContext _context;

        public UsuariosController(ApiContext context)
        {
            _context = context;            
        }

        [HttpGet]
        public ActionResult<IEnumerable<Usuario>> GetAll(){
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public ActionResult<Usuario> GetById(long Id){
            var user = _context.Usuarios.Find(Id);
            
            if(user != null){
                return user;
            }

            return NotFound();
        }

        [HttpPost]
        public IActionResult Create([FromBody] Usuario usuario){
            _context.Usuarios.Add(usuario);
            _context.SaveChanges();

            return Created("usuarios", usuario);
        }

        [HttpPut("{id}")]
        public IActionResult Update(long Id, [FromBody] Usuario usuario){
            if(Id.Equals(usuario.Id)){
                var u = _context.Usuarios.Find(Id);

                u.Username = usuario.Username;
                u.Password = usuario.Password;

                _context.Usuarios.Update(u);
                _context.SaveChanges();
                return NoContent();
            }

            return BadRequest("O Id do usuário não bate");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(long Id){
            var u = _context.Usuarios.Find(Id);
            if(u != null){
                _context.Usuarios.Remove(u);
                _context.SaveChanges();
                return NoContent();
            }

            return NotFound();
        }
        
    }
}